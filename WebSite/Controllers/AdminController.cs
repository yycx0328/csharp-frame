using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;

namespace WebSite.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            OperContext context = OperContext.CurrentContext;
            List<Auth_User> list = context.BllSession.IAuth_UserBLL.QueryBy(p => p.IsAvaiable == true)
                .Select(p => p.ToPOCO()).ToList();
            return Content(list.Count.ToString());
        }

        public ActionResult Add()
        {
            Auth_User u = new Auth_User {
                UserId = System.Guid.NewGuid().ToString("N"),
                UserName = "van",
                Password = "123456",
                PhoneNo = "13651756428",
                Gender = "M",
                Email = "1289927096@qq.com",
                IsAvaiable = true,
                CreateDate = System.DateTime.Now,
                UpdateDate = System.DateTime.Now
            };

            OperContext context = OperContext.CurrentContext;
            int result = context.BllSession.IAuth_UserBLL.Add(u);
            return Content(result.ToString());
        }

    }
}
