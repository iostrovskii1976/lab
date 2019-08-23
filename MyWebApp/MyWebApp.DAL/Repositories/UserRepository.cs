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
    public class UserRepository : Repository<Person>
    {
        public UserRepository(ISession session)
            : base(session)
        {
        }

        public bool Exists(string login)
        {
            var crit = session.CreateCriteria<Person>()
                .Add(Restrictions.Eq("Login", login))
                .SetProjection(Projections.Count("Id"));
            var count = Convert.ToInt64(crit.UniqueResult());
            return count > 0;
        }
    }
}
