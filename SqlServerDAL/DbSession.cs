
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using IDAL;

namespace SqlServerDAL
{
	public partial class DbSession: IDbSession
	{
		#region 01 数据接口 IAuth_AccessDAL
		IAuth_AccessDAL iAuth_AccessDAL;
		public IAuth_AccessDAL IAuth_AccessDAL
		{
			get
			{
				if(iAuth_AccessDAL == null)
					iAuth_AccessDAL = new Auth_AccessDAL();
				return iAuth_AccessDAL;
			}
			set
			{
				iAuth_AccessDAL = value;
			}
		}
		#endregion

		#region 02 数据接口 IAuth_PermissionDAL
		IAuth_PermissionDAL iAuth_PermissionDAL;
		public IAuth_PermissionDAL IAuth_PermissionDAL
		{
			get
			{
				if(iAuth_PermissionDAL == null)
					iAuth_PermissionDAL = new Auth_PermissionDAL();
				return iAuth_PermissionDAL;
			}
			set
			{
				iAuth_PermissionDAL = value;
			}
		}
		#endregion

		#region 03 数据接口 IAuth_RoleDAL
		IAuth_RoleDAL iAuth_RoleDAL;
		public IAuth_RoleDAL IAuth_RoleDAL
		{
			get
			{
				if(iAuth_RoleDAL == null)
					iAuth_RoleDAL = new Auth_RoleDAL();
				return iAuth_RoleDAL;
			}
			set
			{
				iAuth_RoleDAL = value;
			}
		}
		#endregion

		#region 04 数据接口 IAuth_UserDAL
		IAuth_UserDAL iAuth_UserDAL;
		public IAuth_UserDAL IAuth_UserDAL
		{
			get
			{
				if(iAuth_UserDAL == null)
					iAuth_UserDAL = new Auth_UserDAL();
				return iAuth_UserDAL;
			}
			set
			{
				iAuth_UserDAL = value;
			}
		}
		#endregion

		#region 05 数据接口 IAuth_UserRoleDAL
		IAuth_UserRoleDAL iAuth_UserRoleDAL;
		public IAuth_UserRoleDAL IAuth_UserRoleDAL
		{
			get
			{
				if(iAuth_UserRoleDAL == null)
					iAuth_UserRoleDAL = new Auth_UserRoleDAL();
				return iAuth_UserRoleDAL;
			}
			set
			{
				iAuth_UserRoleDAL = value;
			}
		}
		#endregion

		#region 06 数据接口 ICompanyDAL
		ICompanyDAL iCompanyDAL;
		public ICompanyDAL ICompanyDAL
		{
			get
			{
				if(iCompanyDAL == null)
					iCompanyDAL = new CompanyDAL();
				return iCompanyDAL;
			}
			set
			{
				iCompanyDAL = value;
			}
		}
		#endregion

		#region 07 数据接口 IUserDAL
		IUserDAL iUserDAL;
		public IUserDAL IUserDAL
		{
			get
			{
				if(iUserDAL == null)
					iUserDAL = new UserDAL();
				return iUserDAL;
			}
			set
			{
				iUserDAL = value;
			}
		}
		#endregion

		#region 08 数据接口 IUserAccountDAL
		IUserAccountDAL iUserAccountDAL;
		public IUserAccountDAL IUserAccountDAL
		{
			get
			{
				if(iUserAccountDAL == null)
					iUserAccountDAL = new UserAccountDAL();
				return iUserAccountDAL;
			}
			set
			{
				iUserAccountDAL = value;
			}
		}
		#endregion

		#region 09 数据接口 IUserThirdAccountDAL
		IUserThirdAccountDAL iUserThirdAccountDAL;
		public IUserThirdAccountDAL IUserThirdAccountDAL
		{
			get
			{
				if(iUserThirdAccountDAL == null)
					iUserThirdAccountDAL = new UserThirdAccountDAL();
				return iUserThirdAccountDAL;
			}
			set
			{
				iUserThirdAccountDAL = value;
			}
		}
		#endregion

	}
}