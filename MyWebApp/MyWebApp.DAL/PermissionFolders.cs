using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebApp.DAL.Filters;

namespace MyWebApp.DAL
{
    public class PermissionFolders
    {
        public virtual long Id { get; set; }
        public virtual Folder FoldersId { get; set; }
        public virtual string AccessLevel { get; set; }
        public virtual UserGroup UserGroupId { get; set; }
        public virtual Person UserId { get; set; }
    }
    public class PermissionFoldersMap : ClassMap<PermissionFolders>
    {
        public PermissionFoldersMap()
        {
            Id(u => u.Id).GeneratedBy.HiLo("1");
            References(u => u.FoldersId).Cascade.SaveUpdate();
            Map(u => u.AccessLevel).Length(50);
            References(u => u.UserGroupId).Cascade.SaveUpdate();
            References(u => u.UserId).Cascade.SaveUpdate();
        }
    }
}
