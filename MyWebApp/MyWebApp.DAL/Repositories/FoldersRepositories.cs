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
    public class FoldersRepositories : Repository<Folders, FoldersFilter>
    {
        public FoldersRepositories(ISession session)
            : base(session)
        {

        }
    }
}
