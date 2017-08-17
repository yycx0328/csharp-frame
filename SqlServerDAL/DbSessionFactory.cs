using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using IDAL;

namespace SqlServerDAL
{
    public class DbSessionFactory: IDbSessionFactory
    {
        public IDbSession GetDbSession()
        {
            IDbSession dbSession = CallContext.GetData(typeof(DbSessionFactory).Name) as DbSession;
            if (dbSession == null)
            {
                dbSession = new DbSession();
                CallContext.SetData(typeof(DbSessionFactory).Name, dbSession);
            }
            return dbSession;
        }
    }
}
