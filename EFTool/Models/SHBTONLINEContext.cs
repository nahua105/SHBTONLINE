//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// <copyright file="SHBTONLINEContext.cs">
//        Copyright(c)2015  rights reserved.
//        CLR版本：4.0.30319.239
//        开发组织：李文学@上海同岩土木科技工程有限公司
//        所属工程：TM.*
//        生成时间：2018-02-07 15:01
// </copyright>
//------------------------------------------------------------------------------

using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using TM.Data.Models.Mapping;

namespace TM.Data.Models
{
    public partial class SHBTONLINEContext : DbContext
    {
        static SHBTONLINEContext()
        {
            Database.SetInitializer<SHBTONLINEContext>(null);
        }

        public SHBTONLINEContext()
            : base("Name=SHBTONLINEContext")
        {
        }

        /// <summary>
        /// [AttendanceInfo]
        /// </summary>
        public DbSet<AttendanceInfo> AttendanceInfoes { get; set; }
        /// <summary>
        /// [userinfo]
        /// </summary>
        public DbSet<userinfo> userinfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AttendanceInfoMap());
            modelBuilder.Configurations.Add(new userinfoMap());
        }
    }
}