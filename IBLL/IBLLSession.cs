
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;

namespace IBLL
{
	public partial interface IBLLSession
	{
		IAuth_AccessBLL IAuth_AccessBLL { get; set; }
		IAuth_PermissionBLL IAuth_PermissionBLL { get; set; }
		IAuth_RoleBLL IAuth_RoleBLL { get; set; }
		IAuth_UserBLL IAuth_UserBLL { get; set; }
		IAuth_UserRoleBLL IAuth_UserRoleBLL { get; set; }
		ICompanyBLL ICompanyBLL { get; set; }
		IUserBLL IUserBLL { get; set; }
		IUserAccountBLL IUserAccountBLL { get; set; }
		IUserThirdAccountBLL IUserThirdAccountBLL { get; set; }
	}
}