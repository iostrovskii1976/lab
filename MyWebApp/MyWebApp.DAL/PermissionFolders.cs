using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.DAL
{
    public class PermissionFolders
    {
        public virtual Folders FoldersId { get; set; }
        public virtual string AccessLevel { get; set; }
        public virtual UserGroup UserGroupId { get; set; }
        public virtual User UserId { get; set; }
    }
    public class PermissionFoldersMap : ClassMap<PermissionFolders>
    {
        public PermissionFoldersMap()
        {
            References(u => u.FoldersId).Cascade.SaveUpdate();
            Map(u => u.AccessLevel).Length(50);
            References(u => u.UserGroupId).Cascade.SaveUpdate();
            References(u => u.UserId).Cascade.SaveUpdate();
        }
    }
}
