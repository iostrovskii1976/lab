using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebWorkflow.ModelBD
{

    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public int GroupsUsersId { get; set; }
    }

    public class GroupUsers
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
    }

    public class Document
    {
        public string DocumentType { get; set; }
        public DateTime Date { get; set; }
        public int UsersId { get; set; }
    }

    public class Folders
    {
        public int Id { get; set; }
        public string NameFolder { get; set; }
    }

    public class DocumentVersion
    {
        public int Id { get; set; }
        public byte[] File { get; set; }
        public int UsersId { get; set; }
    }

    public class PermissionFolders
    {
        public int FoldersId { get; set; }
        public string AccessLevel { get; set; }
        public int GroupsUsersId { get; set; }
        public int UsersId { get; set; }
    }
}