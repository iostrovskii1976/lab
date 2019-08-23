using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Criterion;

namespace MyWebApp.DAL.Repositories
{
    [Repository]
    public class UserGroupRepositories : Repository<UserGroup>
    {
        public UserGroupRepositories(ISession session)
            : base(session)
        {
        }
        public bool Exists(string group)
        {
            var crit = session.CreateCriteria<UserGroup>()
                .Add(Restrictions.Eq("Group", group))
                .SetProjection(Projections.Count("Id"));
            var count = Convert.ToInt64(crit.UniqueResult());
            return count > 0;
        }
    }
}
