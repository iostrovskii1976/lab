using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApp.Models
{
    public class EntityListModel<T>
    {
        public IList<T> Items {get; set;}
    }
}