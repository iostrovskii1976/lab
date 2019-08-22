using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebWorkflow
{
    public class Users
    {
        public class User
        {
            public virtual long Id { get; set; }
            public virtual string Login { get; set; }
            public virtual string Pass { get; set; }
            public virtual UserGroup Group { get; set; }
        }
        public class UserMap : ClassMapping<User>
        {
            public UserMap()
            {

            }
        }
    }
}