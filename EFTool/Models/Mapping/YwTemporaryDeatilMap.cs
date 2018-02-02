	
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// <copyright file="YwTemporaryDeatilMap.cs">
//        Copyright(c)2015   rights reserved.
//        CLR版本：4.0.30319.239
//        开发组织：李文学@上海同岩土木科技工程有限公司
//        所属工程：TY.*
//        生成时间：2016-12-15 09:54
// </copyright>
//------------------------------------------------------------------------------

	using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TY.SHMetroPlan.Data.Domain.Models.Mapping
{
    public class YwTemporaryDeatilMap : EntityTypeConfiguration<YwTemporaryDeatil>
    {
        public YwTemporaryDeatilMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.TaskDetailCode)
                .HasMaxLength(200);

            this.Property(t => t.TaskId)
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.TaskCode)
                .HasMaxLength(200);

            this.Property(t => t.WorkAreaId)
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.WorkAreaCode)
                .HasMaxLength(200);

            this.Property(t => t.NodeId)
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.NodeCode)
                .HasMaxLength(200);

            this.Property(t => t.RouteId)
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.RouteCode)
                .HasMaxLength(200);

            this.Property(t => t.StartMileagePrefix)
                .HasMaxLength(200);

            this.Property(t => t.EndMleagePrefix)
                .HasMaxLength(200);

            this.Property(t => t.ReMark)
                .HasMaxLength(400);

            // Table & Column Mappings
            this.ToTable("YwTemporaryDeatil");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TaskDetailCode).HasColumnName("TaskDetailCode");
            this.Property(t => t.TaskId).HasColumnName("TaskId");
            this.Property(t => t.TaskCode).HasColumnName("TaskCode");
            this.Property(t => t.WorkAreaId).HasColumnName("WorkAreaId");
            this.Property(t => t.WorkAreaCode).HasColumnName("WorkAreaCode");
            this.Property(t => t.NodeId).HasColumnName("NodeId");
            this.Property(t => t.NodeCode).HasColumnName("NodeCode");
            this.Property(t => t.NodeType).HasColumnName("NodeType");
            this.Property(t => t.Direction).HasColumnName("Direction");
            this.Property(t => t.RouteId).HasColumnName("RouteId");
            this.Property(t => t.RouteCode).HasColumnName("RouteCode");
            this.Property(t => t.RangeType).HasColumnName("RangeType");
            this.Property(t => t.StartMileage).HasColumnName("StartMileage");
            this.Property(t => t.EndmMleage).HasColumnName("EndmMleage");
            this.Property(t => t.StartMileagePrefix).HasColumnName("StartMileagePrefix");
            this.Property(t => t.EndMleagePrefix).HasColumnName("EndMleagePrefix");
            this.Property(t => t.ExStartTime).HasColumnName("ExStartTime");
            this.Property(t => t.ExEndTime).HasColumnName("ExEndTime");
            this.Property(t => t.ReMark).HasColumnName("ReMark");
            this.Property(t => t.CreatTime).HasColumnName("CreatTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");

            // Relationships
            this.HasOptional(t => t.YwTemporaryTask)
                .WithMany(t => t.YwTemporaryDeatils)
                .HasForeignKey(d => d.TaskId);

        }
    }
}