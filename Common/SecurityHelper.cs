/*****************************************************
 * Author: 卢云海
 * Mail: lyh_oralce@hotmail.com
 * QQ: 1289927096
 * Date: 2017-04-20
 * **************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

namespace Common
{
    #region 加解密
    public class SecurityHelper
    { 
        #region 加密
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="userData">用户信息</param>
        /// <returns>加密字符串</returns>
        public static string Encrypt(string userData)
        {
            // 将用户数据存入票据对象
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, "vanluu", DateTime.Now, DateTime.Now.AddMinutes(10), true, userData);
            // 将票据对象加密成字符串
            string security = FormsAuthentication.Encrypt(ticket);
            return security;
        } 
        #endregion

        #region 解密
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="encryptedTicket">加密字符串</param>
        /// <returns>用户数据</returns>
        public static string Decrypt(string encryptedTicket)
        {
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(encryptedTicket);
            return ticket.UserData;
        } 
        #endregion
    } 
    #endregion
}
