using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.DAL
{
    public class DocumentVersion
    {
        public virtual int Id { get; set; }
        public virtual byte[] File { get; set; }
        public virtual Person UsersId { get; set; }
    }
    public class DocumentVersionMap : ClassMap<DocumentVersion>
    {
        public DocumentVersionMap()
        {
            Id(u => u.Id).GeneratedBy.HiLo("1");
            Map(u => u.File);
            References(u => u.UsersId).Cascade.SaveUpdate();
        }
    }
}
