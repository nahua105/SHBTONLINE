	
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// <copyright file="AttendanceInfo.cs">
//        Copyright(c)2015   rights reserved.
//        CLR版本：4.0.30319.239
//        开发组织：李文学@上海同岩土木科技工程有限公司
//        所属工程：TY.*
//        生成时间：2018-02-07 15:01
// </copyright>
//------------------------------------------------------------------------------

	using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Data.Domain;
using Data.DomainMap;

//namespace TM.Data.Models.Mapping
namespace Data.DomainMap
    public class AttendanceInfoMap : EntityTypeConfiguration<AttendanceInfo>
    {
        public AttendanceInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(36);

            this.Property(t => t.AD_Id)
                .HasMaxLength(20);

            this.Property(t => t.AD_LoginName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("AttendanceInfo");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.AD_Id).HasColumnName("AD_Id");
            this.Property(t => t.AD_AttendTime).HasColumnName("AD_AttendTime");
            this.Property(t => t.AD_LoginName).HasColumnName("AD_LoginName");
            this.Property(t => t.Create_Time).HasColumnName("Create_Time");
        }
    }
}
