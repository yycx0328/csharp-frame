
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using IBLL;

namespace SqlServerBLL
{
	public partial class BLLSession: IBLLSession
	{
		#region 01 业务接口 IAuth_AccessBLL
		IAuth_AccessBLL iAuth_AccessBLL;
		public IAuth_AccessBLL IAuth_AccessBLL
		{
			get
			{
				if(iAuth_AccessBLL == null)
					iAuth_AccessBLL = new Auth_AccessService();
				return iAuth_AccessBLL;
			}
			set
			{
				iAuth_AccessBLL = value;
			}
		}
		#endregion

		#region 02 业务接口 IAuth_PermissionBLL
		IAuth_PermissionBLL iAuth_PermissionBLL;
		public IAuth_PermissionBLL IAuth_PermissionBLL
		{
			get
			{
				if(iAuth_PermissionBLL == null)
					iAuth_PermissionBLL = new Auth_PermissionService();
				return iAuth_PermissionBLL;
			}
			set
			{
				iAuth_PermissionBLL = value;
			}
		}
		#endregion

		#region 03 业务接口 IAuth_RoleBLL
		IAuth_RoleBLL iAuth_RoleBLL;
		public IAuth_RoleBLL IAuth_RoleBLL
		{
			get
			{
				if(iAuth_RoleBLL == null)
					iAuth_RoleBLL = new Auth_RoleService();
				return iAuth_RoleBLL;
			}
			set
			{
				iAuth_RoleBLL = value;
			}
		}
		#endregion

		#region 04 业务接口 IAuth_UserBLL
		IAuth_UserBLL iAuth_UserBLL;
		public IAuth_UserBLL IAuth_UserBLL
		{
			get
			{
				if(iAuth_UserBLL == null)
					iAuth_UserBLL = new Auth_UserService();
				return iAuth_UserBLL;
			}
			set
			{
				iAuth_UserBLL = value;
			}
		}
		#endregion

		#region 05 业务接口 IAuth_UserRoleBLL
		IAuth_UserRoleBLL iAuth_UserRoleBLL;
		public IAuth_UserRoleBLL IAuth_UserRoleBLL
		{
			get
			{
				if(iAuth_UserRoleBLL == null)
					iAuth_UserRoleBLL = new Auth_UserRoleService();
				return iAuth_UserRoleBLL;
			}
			set
			{
				iAuth_UserRoleBLL = value;
			}
		}
		#endregion

		#region 06 业务接口 ICompanyBLL
		ICompanyBLL iCompanyBLL;
		public ICompanyBLL ICompanyBLL
		{
			get
			{
				if(iCompanyBLL == null)
					iCompanyBLL = new CompanyService();
				return iCompanyBLL;
			}
			set
			{
				iCompanyBLL = value;
			}
		}
		#endregion

		#region 07 业务接口 IUserBLL
		IUserBLL iUserBLL;
		public IUserBLL IUserBLL
		{
			get
			{
				if(iUserBLL == null)
					iUserBLL = new UserService();
				return iUserBLL;
			}
			set
			{
				iUserBLL = value;
			}
		}
		#endregion

		#region 08 业务接口 IUserAccountBLL
		IUserAccountBLL iUserAccountBLL;
		public IUserAccountBLL IUserAccountBLL
		{
			get
			{
				if(iUserAccountBLL == null)
					iUserAccountBLL = new UserAccountService();
				return iUserAccountBLL;
			}
			set
			{
				iUserAccountBLL = value;
			}
		}
		#endregion

		#region 09 业务接口 IUserThirdAccountBLL
		IUserThirdAccountBLL iUserThirdAccountBLL;
		public IUserThirdAccountBLL IUserThirdAccountBLL
		{
			get
			{
				if(iUserThirdAccountBLL == null)
					iUserThirdAccountBLL = new UserThirdAccountService();
				return iUserThirdAccountBLL;
			}
			set
			{
				iUserThirdAccountBLL = value;
			}
		}
		#endregion

	}
}