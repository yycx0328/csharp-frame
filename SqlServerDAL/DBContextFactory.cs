using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;
using Models;

namespace SqlServerDAL
{
    public class DBContextFactory : IDBContextFacory
    {
        #region 通过线程对数据上下文进行优化
        /// <summary>
        /// 通过线程对数据上下文进行优化
        /// </summary>
        /// <returns></returns>
        public DbContext GetDbContext()
        {
            DbContext dbContext = CallContext.GetData(typeof(DBContextFactory).Name) as DbContext;
            if(dbContext == null)
            {
                dbContext = new RecruitEntities();
                CallContext.SetData(typeof(DBContextFactory).Name, dbContext);
            }
            return dbContext;
        }
        #endregion
    }
}
