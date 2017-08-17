
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;

namespace IBLL
{
	public partial interface IAuth_AccessBLL : IBaseBLL<Auth_Access>
	{
	}

	public partial interface IAuth_PermissionBLL : IBaseBLL<Auth_Permission>
	{
	}

	public partial interface IAuth_RoleBLL : IBaseBLL<Auth_Role>
	{
	}

	public partial interface IAuth_UserBLL : IBaseBLL<Auth_User>
	{
	}

	public partial interface IAuth_UserRoleBLL : IBaseBLL<Auth_UserRole>
	{
	}

	public partial interface ICompanyBLL : IBaseBLL<Company>
	{
	}

	public partial interface IUserBLL : IBaseBLL<User>
	{
	}

	public partial interface IUserAccountBLL : IBaseBLL<UserAccount>
	{
	}

	public partial interface IUserThirdAccountBLL : IBaseBLL<UserThirdAccount>
	{
	}

}