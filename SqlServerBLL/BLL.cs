
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using IBLL;

namespace SqlServerBLL
{
	public partial class Auth_AccessService : BaseBLL<Auth_Access>,IAuth_AccessBLL
	{
		public Auth_AccessService()
		{
			idal = DbSession.IAuth_AccessDAL;
		}
	}

	public partial class Auth_PermissionService : BaseBLL<Auth_Permission>,IAuth_PermissionBLL
	{
		public Auth_PermissionService()
		{
			idal = DbSession.IAuth_PermissionDAL;
		}
	}

	public partial class Auth_RoleService : BaseBLL<Auth_Role>,IAuth_RoleBLL
	{
		public Auth_RoleService()
		{
			idal = DbSession.IAuth_RoleDAL;
		}
	}

	public partial class Auth_UserService : BaseBLL<Auth_User>,IAuth_UserBLL
	{
		public Auth_UserService()
		{
			idal = DbSession.IAuth_UserDAL;
		}
	}

	public partial class Auth_UserRoleService : BaseBLL<Auth_UserRole>,IAuth_UserRoleBLL
	{
		public Auth_UserRoleService()
		{
			idal = DbSession.IAuth_UserRoleDAL;
		}
	}

	public partial class CompanyService : BaseBLL<Company>,ICompanyBLL
	{
		public CompanyService()
		{
			idal = DbSession.ICompanyDAL;
		}
	}

	public partial class UserService : BaseBLL<User>,IUserBLL
	{
		public UserService()
		{
			idal = DbSession.IUserDAL;
		}
	}

	public partial class UserAccountService : BaseBLL<UserAccount>,IUserAccountBLL
	{
		public UserAccountService()
		{
			idal = DbSession.IUserAccountDAL;
		}
	}

	public partial class UserThirdAccountService : BaseBLL<UserThirdAccount>,IUserThirdAccountBLL
	{
		public UserThirdAccountService()
		{
			idal = DbSession.IUserThirdAccountDAL;
		}
	}

}