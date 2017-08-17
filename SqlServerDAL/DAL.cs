
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using IDAL;

namespace SqlServerDAL
{
	public partial class Auth_AccessDAL : BaseDAL<Auth_Access>,IAuth_AccessDAL
	{
	}

	public partial class Auth_PermissionDAL : BaseDAL<Auth_Permission>,IAuth_PermissionDAL
	{
	}

	public partial class Auth_RoleDAL : BaseDAL<Auth_Role>,IAuth_RoleDAL
	{
	}

	public partial class Auth_UserDAL : BaseDAL<Auth_User>,IAuth_UserDAL
	{
	}

	public partial class Auth_UserRoleDAL : BaseDAL<Auth_UserRole>,IAuth_UserRoleDAL
	{
	}

	public partial class CompanyDAL : BaseDAL<Company>,ICompanyDAL
	{
	}

	public partial class UserDAL : BaseDAL<User>,IUserDAL
	{
	}

	public partial class UserAccountDAL : BaseDAL<UserAccount>,IUserAccountDAL
	{
	}

	public partial class UserThirdAccountDAL : BaseDAL<UserThirdAccount>,IUserThirdAccountDAL
	{
	}

}