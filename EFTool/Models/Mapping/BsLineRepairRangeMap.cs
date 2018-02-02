	
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// <copyright file="BsLineRepairRangeMap.cs">
//        Copyright(c)2015   rights reserved.
//        CLR版本：4.0.30319.239
//        开发组织：李文学@上海同岩土木科技工程有限公司
//        所属工程：TY.*
//        生成时间：2016-12-15 09:52
// </copyright>
//------------------------------------------------------------------------------

	using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TY.SHMetroPlan.Data.DomainMap
{
    public class BsLineRepairRangeMap : EntityTypeConfiguration<BsLineRepairRange>
    {
        public BsLineRepairRangeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.StartLineId)
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.EndLineId)
                .IsFixedLength()
                .HasMaxLength(36);

            // Table & Column Mappings
            this.ToTable("BsLineRepairRange");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StartLineId).HasColumnName("StartLineId");
            this.Property(t => t.EndLineId).HasColumnName("EndLineId");
            this.Property(t => t.StartMileage).HasColumnName("StartMileage");
            this.Property(t => t.EndMileage).HasColumnName("EndMileage");
            this.Property(t => t.MileageLengh).HasColumnName("MileageLengh");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");

            // Relationships
            this.HasOptional(t => t.BsLineInfo)
                .WithMany(t => t.BsLineRepairRanges)
                .HasForeignKey(d => d.StartLineId);
            this.HasOptional(t => t.BsLineInfo1)
                .WithMany(t => t.BsLineRepairRanges1)
                .HasForeignKey(d => d.EndLineId);

        }
    }
}