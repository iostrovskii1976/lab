using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.DAL
{
    public class Document
    {
        public virtual string DocumentType { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual User UsersId { get; set; }

    }
    public class DocumentMap : ClassMap<Document>
    {
        public DocumentMap()
        {
            Map(u => u.DocumentType).Length(100);
            Map(u => u.Date);
            References(u => u.UsersId).Cascade.SaveUpdate();
        }
    }
}
