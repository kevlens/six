using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Model;

namespace DAL
{
    public class EFContextFactory : IEFContextFactory
    {
        public DbContext GetDbContext()
        {
            DbContext dbContext = CallContext.GetData(typeof(EFContextFactory).Name) as DbContext;
            if (dbContext == null)
            {
                dbContext = new Entities();
                CallContext.SetData(typeof(EFContextFactory).Name, dbContext);
            }

            return dbContext;
        }
    }
}
