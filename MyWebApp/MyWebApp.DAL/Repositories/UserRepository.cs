using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Criterion;
using MyWebApp.DAL.Filters;

namespace MyWebApp.DAL.Repositories
{
    [Repository]
    public class UserRepository : Repository<Person, UserFilter>
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

        public IList<Person> GetUserGroupList()
        {
            var crit = session.CreateCriteria<UserGroup>();
            return crit.List<Person>();
        }

        protected override void SetupFilter(ICriteria crit, UserFilter filter)
        {
            base.SetupFilter(crit, filter);
            if (!string.IsNullOrEmpty(filter.Login))
            {
                crit.Add(Restrictions.Eq("Login", filter.Login));
            }
            //if (!string.IsNullOrEmpty(filter.FIO))
            //{
            //    crit.Add(Restrictions.InsensitiveLike("FIO", filter.FIO, MatchMode.Anywhere));
            //}
            //if (!string.IsNullOrEmpty(filter.Email))
            //{
            //    crit.Add(Restrictions.Eq("Email", filter.Email));
            //}
            //if (filter.CreationDate.From.HasValue)
            //{
            //    crit.Add(Restrictions.Ge("CreationDate", filter.CreationDate.From.Value));
            //}
            //if (filter.CreationDate.To.HasValue)
            //{
            //    crit.Add(Restrictions.Le("CreationDate", filter.CreationDate.To.Value));
            //}
            //if (filter.Age.From.HasValue)
            //{
            //    crit.Add(Restrictions.Ge("Age", filter.Age.From.Value));
            //}
            //if (filter.Age.To.HasValue)
            //{
            //    crit.Add(Restrictions.Le("Age", filter.Age.To.Value));
            //}
            //if (filter.CreationAuthor != null && filter.CreationAuthor.Count > 0)
            //{
            //    crit.Add(Restrictions.In("CreationAuthor", filter.CreationAuthor.ToArray()));
            //}
            if (filter.Group != null && filter.Group.Count > 0)
            {
                crit.Add(Restrictions.In("Group", filter.Group.ToArray()));
            }
        }
    }
}
