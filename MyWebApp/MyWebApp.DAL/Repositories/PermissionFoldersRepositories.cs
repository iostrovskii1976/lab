using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebApp.DAL.Filters;

namespace MyWebApp.DAL.Repositories
{
    [Repository]
    public class PermissionFoldersRepositories : Repository<PermissionFolders, PermissionFoldersFilter>
    {
        public PermissionFoldersRepositories(ISession session)
            : base(session)
        {

        }
    }
}
