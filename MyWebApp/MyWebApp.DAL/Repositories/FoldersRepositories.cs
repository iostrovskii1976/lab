﻿using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.DAL.Repositories
{
    public class FoldersRepositories : Repository<Folders>
    {
        public FoldersRepositories(ISession session)
            : base(session)
        {

        }
    }
}
