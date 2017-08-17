using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IBLL;
using DI;
using System.Runtime.Remoting.Messaging;

namespace WebSite.Controllers
{
    public class OperContext
    {
        #region Old Code
        //private IBLLSession iBllSession;
        //public IBLLSession BllSession
        //{
        //    get
        //    {
        //        if (iBllSession == null)
        //        {
        //            IBLLSessionFactory bllSessionFactory = SpringHelper.GetObject<IBLLSessionFactory>("BLLSessionFactory");
        //            iBllSession = bllSessionFactory.GetBLLSession();
        //        }
        //        return iBllSession;
        //    }
        //}
        #endregion

        public IBLLSession BllSession;
        private OperContext()
        {
            BllSession = SpringHelper.GetObject<IBLLSession>("BLLSession");
        }

        public static OperContext CurrentContext
        {
            get
            {
                OperContext opContext = CallContext.GetData(typeof(OperContext).Name) as OperContext;
                if (opContext == null)
                {
                    opContext = new OperContext();
                    CallContext.SetData(typeof(OperContext).Name,opContext);
                }
                return opContext;
            }
        }
    }
}