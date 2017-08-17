
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;

namespace IDAL
{
	public partial interface IAuth_AccessDAL : IBaseDAL<Auth_Access>
	{
	}

	public partial interface IAuth_PermissionDAL : IBaseDAL<Auth_Permission>
	{
	}

	public partial interface IAuth_RoleDAL : IBaseDAL<Auth_Role>
	{
	}

	public partial interface IAuth_UserDAL : IBaseDAL<Auth_User>
	{
	}

	public partial interface IAuth_UserRoleDAL : IBaseDAL<Auth_UserRole>
	{
	}

	public partial interface ICompanyDAL : IBaseDAL<Company>
	{
	}

	public partial interface IUserDAL : IBaseDAL<User>
	{
	}

	public partial interface IUserAccountDAL : IBaseDAL<UserAccount>
	{
	}

	public partial interface IUserThirdAccountDAL : IBaseDAL<UserThirdAccount>
	{
	}

}