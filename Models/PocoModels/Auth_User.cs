//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Auth_User
    {
    	public Auth_User ToPOCO(bool isPOCO = true){
    		return new Auth_User{
    			UserId = this.UserId,
    			UserName = this.UserName,
    			Password = this.Password,
    			PhoneNo = this.PhoneNo,
    			Email = this.Email,
    			Gender = this.Gender,
    			IsAvaiable = this.IsAvaiable,
    			CreateDate = this.CreateDate,
    			UpdateDate = this.UpdateDate,
    		};
    	}
    }
}