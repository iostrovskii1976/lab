using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.DAL.Repositories
{
    public class DocumentRepositories : Repository<Document>
    {
        public DocumentRepositories(ISession session)
            : base(session)
        {

        }
    }
}
