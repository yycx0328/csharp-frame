﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RecruitEntities : DbContext
    {
        public RecruitEntities()
            : base("name=RecruitEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Auth_Permission> Auth_Permission { get; set; }
        public DbSet<Auth_Role> Auth_Role { get; set; }
        public DbSet<Auth_User> Auth_User { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<UserThirdAccount> UserThirdAccounts { get; set; }
        public DbSet<Auth_Access> Auth_Access { get; set; }
        public DbSet<Auth_UserRole> Auth_UserRole { get; set; }
    }
}
