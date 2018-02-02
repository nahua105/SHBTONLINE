	
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// <copyright file="BsFacilityDiseaseMap.cs">
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
    public class BsFacilityDiseaseMap : EntityTypeConfiguration<BsFacilityDisease>
    {
        public BsFacilityDiseaseMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.FacilityPartId)
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.FacilityPartCode)
                .HasMaxLength(200);

            this.Property(t => t.DiseaseTypeCode)
                .HasMaxLength(200);

            this.Property(t => t.DiseaseTypeName)
                .HasMaxLength(200);

            this.Property(t => t.Remark)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BsFacilityDisease");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FacilityPartId).HasColumnName("FacilityPartId");
            this.Property(t => t.FacilityPartCode).HasColumnName("FacilityPartCode");
            this.Property(t => t.DiseaseTypeCode).HasColumnName("DiseaseTypeCode");
            this.Property(t => t.DiseaseTypeName).HasColumnName("DiseaseTypeName");
            this.Property(t => t.IsEnabled).HasColumnName("IsEnabled");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.SortId).HasColumnName("SortId");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");

            // Relationships
            this.HasOptional(t => t.BsFacilityPart)
                .WithMany(t => t.BsFacilityDiseases)
                .HasForeignKey(d => d.FacilityPartId);

        }
    }
}