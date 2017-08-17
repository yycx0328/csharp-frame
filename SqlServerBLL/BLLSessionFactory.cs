using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using System.Runtime.Remoting.Messaging;

namespace SqlServerBLL
{
    public class BLLSessionFactory: IBLLSessionFactory
    {
        public IBLLSession GetBLLSession()
        {
            IBLLSession bllSession = CallContext.GetData(typeof(BLLSessionFactory).Name) as BLLSession;
            if (bllSession == null)
            {
                bllSession = new BLLSession();
                CallContext.SetData(typeof(BLLSessionFactory).Name, bllSession);
            }
            return bllSession;
        }
    }
}
