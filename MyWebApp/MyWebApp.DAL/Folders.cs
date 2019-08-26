using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebApp.DAL.Filters;

namespace MyWebApp.DAL
{
    public class Folders
    {
        public virtual long Id { get; set; }
        public virtual string NameFolder { get; set; }
    }
    public class FoldersMap : ClassMap<Folders>
    {
        public FoldersMap()
        {
            Id(u => u.Id).GeneratedBy.HiLo("1");
            Map(u => u.NameFolder).Length(256);
        }
    }
}
