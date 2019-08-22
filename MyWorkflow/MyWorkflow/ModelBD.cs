using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;


namespace WebWorkflow.ModelBD
{

    public class User
    {
        public virtual int Id { get; set; }
        public virtual string Login { get; set; }
        public virtual string Pass { get; set; }
        public virtual int GroupsUsersId { get; set; }
    }

    //Маппинг класса User
    public class UserMap : ClassMapping<User>
    {
        public UserMap()
        {
            Table("User");
            Id(x => x.Id, map => { map.Column("Id"); map.Generator(Generators.Identity); });
            Property(x => x.Login, map => { map.Column("Login"); } );
            Property(x => x.Pass, map => { map.Column("Pass"); });
            Property(x => x.GroupsUsersId, map => { map.Column("GroupsUsersId"); });
        }
    }


    public class GroupUsers
    {
        public virtual int Id { get; set; }
        public virtual string GroupName { get; set; }
    }
    //Маппинг класса GroupUsers
    public class GroupUsersMap : ClassMapping<GroupUsers>
    {
        public GroupUsersMap()
        {
            Table("GroupUsers");
            Id(x => x.Id, map => { map.Column("Id"); map.Generator(Generators.Identity); });
            Property(x => x.GroupName, map => { map.Column("GroupName"); });
        }
    }

    public class Document
    {
        public virtual string DocumentType { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual int UsersId { get; set; }
    }
    //Маппинг класса Document
    public class DocumentMap : ClassMapping<Document> 
    {
        public DocumentMap()
        {
            Table("Document");
            Property(x => x.DocumentType, map => { map.Column("DocumentType"); });
            Property(x => x.Date, map => { map.Column("Date"); });
            Property(x => x.UsersId, map => { map.Column("UsersId"); });
        }
    }

    public class Folders
    {
        public virtual int Id { get; set; }
        public virtual string NameFolder { get; set; }
    }
    //Маппинг класса Folders
    public class FoldersMap : ClassMapping<Folders>
    {
        public FoldersMap()
        {
            Table("Folders");
            Id(x => x.Id, map => { map.Column("Id"); map.Generator(Generators.Identity); });
            Property(x => x.NameFolder, map => { map.Column("NameFolder"); });
        }
    }

    public class DocumentVersion
    {
        public virtual int Id { get; set; }
        public virtual byte[] File { get; set; }
        public virtual int UsersId { get; set; }
    }
    //Маппинг класса Folders
    public class DocumentVersionMap : ClassMapping<DocumentVersion>
    {
        public DocumentVersionMap()
        {
            Table("DocumentVersion");
            Id(x => x.Id, map => { map.Column("Id"); map.Generator(Generators.Identity); });
            Property(x => x.File, map => { map.Column("File"); });
            Property(x => x.UsersId, map => { map.Column("UsersId"); });
        }
    }

    public class PermissionFolders
    {
        public virtual int FoldersId { get; set; }
        public virtual string AccessLevel { get; set; }
        public virtual int GroupsUsersId { get; set; }
        public virtual int UsersId { get; set; }
    }
    //Маппинг класса PermissionFolders
    public class PermissionFoldersMap : ClassMapping<PermissionFolders>
    {
        public PermissionFoldersMap()
        {
            Table("PermissionFolders");
            Property(x => x.FoldersId, map => { map.Column("FoldersId"); });
            Property(x => x.AccessLevel, map => { map.Column("AccessLevel"); });
            Property(x => x.GroupsUsersId, map => { map.Column("GroupsUsersId"); });
            Property(x => x.UsersId, map => { map.Column("UsersId"); });
        }
    }
}