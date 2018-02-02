	
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// <copyright file="BsMtWorkflowMap.cs">
//        Copyright(c)2015   rights reserved.
//        CLR版本：4.0.30319.239
//        开发组织：李文学@上海同岩土木科技工程有限公司
//        所属工程：TY.*
//        生成时间：2016-12-15 09:52
// </copyright>
//------------------------------------------------------------------------------

	using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TY.SHMetroPlan.Data.Domain.Models.Mapping
{
    public class BsMtWorkflowMap : EntityTypeConfiguration<BsMtWorkflow>
    {
        public BsMtWorkflowMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.PurchaseId)
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.PurchaseCode)
                .HasMaxLength(200);

            this.Property(t => t.SpCode)
                .HasMaxLength(200);

            this.Property(t => t.WorkflowId)
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.Remark)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BsMtWorkflow");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PurchaseId).HasColumnName("PurchaseId");
            this.Property(t => t.PurchaseCode).HasColumnName("PurchaseCode");
            this.Property(t => t.SpCode).HasColumnName("SpCode");
            this.Property(t => t.WorkflowId).HasColumnName("WorkflowId");
            this.Property(t => t.WorkflowState).HasColumnName("WorkflowState");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.SortId).HasColumnName("SortId");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");

            // Relationships
            this.HasOptional(t => t.BsMtPurchase)
                .WithMany(t => t.BsMtWorkflows)
                .HasForeignKey(d => d.PurchaseId);

        }
    }
}