using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.DAL.Repositories
{
    [Repository]
    public class UserGroupRepositories : Repository<UserGroup>
    {
        public UserGroupRepositories(ISession session)
            : base(session)
        {

        }
    }
}
