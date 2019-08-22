using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.DAL
{
    public class User
    {
        public virtual long Id { get; set; }
        public virtual string Login { get; set; }
        public virtual string Pass { get; set; }
        public virtual UserGroup Group { get; set; }
    }

    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(u => u.Id).GeneratedBy.HiLo("1");
            Map(u => u.Login).Length(100);
            Map(u => u.Pass).Length(100);
            References(u => u.Group).Cascade.SaveUpdate();
        }
    }
}

