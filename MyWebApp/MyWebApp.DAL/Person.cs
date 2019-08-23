﻿using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.DAL
{
    public class Person
    {
        public virtual long Id { get; set; }
        public virtual string Login { get; set; }
        public virtual string Pass { get; set; }
        public virtual UserGroup Group { get; set; }
     //  public virtual IList<DocumentVersion>  DocumentVersions { get; set; }
     //  public virtual IList<Document> Documents { get; set; }
    }

    public class UserMap : ClassMap<Person>
    {
        public UserMap()
        {
            //Table("Users");
            Id(u => u.Id).GeneratedBy.HiLo("1");
            Map(u => u.Login).Length(100);
            Map(u => u.Pass).Length(100);
            References(u => u.Group).Cascade.SaveUpdate();
         //   References(u => u.DocumentVersions).Cascade.SaveUpdate();
         //   HasMany(u => u.Documents).Inverse();
         //   HasMany(u => u.DocumentVersions).Inverse();
        }
    }
}

