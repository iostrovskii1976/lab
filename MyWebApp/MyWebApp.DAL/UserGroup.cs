using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebApp.DAL.Filters;

namespace MyWebApp.DAL
{
    public class UserGroup
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Person> Users { get; set; }
    }
    public class UserGroupMap : ClassMap<UserGroup>
    {
        public UserGroupMap()
        {
            Id(u => u.Id).GeneratedBy.HiLo("100");
            Map(u => u.Name).Length(100);
            HasMany(u => u.Users).Inverse();
        }
    }

}