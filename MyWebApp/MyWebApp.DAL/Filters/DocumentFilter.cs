using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.DAL.Filters
{
    public class DocumentFilter: BaseFilter
    {
        public string DocumentType { get; set; }
        public DateTime Date { get; set; }
    }
}
