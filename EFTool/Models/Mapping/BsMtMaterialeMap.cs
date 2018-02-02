	
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// <copyright file="BsMtMaterialeMap.cs">
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
    public class BsMtMaterialeMap : EntityTypeConfiguration<BsMtMateriale>
    {
        public BsMtMaterialeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.MtTypeId)
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.MtTypeCode)
                .HasMaxLength(200);

            this.Property(t => t.MaterialCode)
                .HasMaxLength(200);

            this.Property(t => t.MaterialModeller)
                .HasMaxLength(200);

            this.Property(t => t.MaterialUnitName)
                .HasMaxLength(200);

            this.Property(t => t.MaterialBrand)
                .HasMaxLength(200);

            this.Property(t => t.Teknologi)
                .HasMaxLength(400);

            this.Property(t => t.Remark)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BsMtMateriale");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.MtTypeId).HasColumnName("MtTypeId");
            this.Property(t => t.MtTypeCode).HasColumnName("MtTypeCode");
            this.Property(t => t.MaterialCode).HasColumnName("MaterialCode");
            this.Property(t => t.MaterialModeller).HasColumnName("MaterialModeller");
            this.Property(t => t.MaterialUnitName).HasColumnName("MaterialUnitName");
            this.Property(t => t.Maleenhed).HasColumnName("Maleenhed");
            this.Property(t => t.MaterialBrand).HasColumnName("MaterialBrand");
            this.Property(t => t.Teknologi).HasColumnName("Teknologi");
            this.Property(t => t.IsEnabled).HasColumnName("IsEnabled");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.SortId).HasColumnName("SortId");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");

            // Relationships
            this.HasOptional(t => t.BsMtCategory)
                .WithMany(t => t.BsMtMateriales)
                .HasForeignKey(d => d.MtTypeId);

        }
    }
}