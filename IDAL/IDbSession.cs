
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;

namespace IDAL
{
	public partial interface IDbSession
	{
		IAuth_AccessDAL IAuth_AccessDAL { get; set; }
		IAuth_PermissionDAL IAuth_PermissionDAL { get; set; }
		IAuth_RoleDAL IAuth_RoleDAL { get; set; }
		IAuth_UserDAL IAuth_UserDAL { get; set; }
		IAuth_UserRoleDAL IAuth_UserRoleDAL { get; set; }
		ICompanyDAL ICompanyDAL { get; set; }
		IUserDAL IUserDAL { get; set; }
		IUserAccountDAL IUserAccountDAL { get; set; }
		IUserThirdAccountDAL IUserThirdAccountDAL { get; set; }
	}
}