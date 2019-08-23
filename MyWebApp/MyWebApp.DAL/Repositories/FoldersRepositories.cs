using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.DAL.Repositories
{
    [Repository]
    public class FoldersRepositories : Repository<Folders>
    {
        public FoldersRepositories(ISession session)
            : base(session)
        {

        }
    }
}
