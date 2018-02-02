	
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// <copyright file="YwDiseaseEvaluateMap.cs">
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
    public class YwDiseaseEvaluateMap : EntityTypeConfiguration<YwDiseaseEvaluate>
    {
        public YwDiseaseEvaluateMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.RecordCode)
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.DiseaseCode)
                .HasMaxLength(200);

            this.Property(t => t.EvaluateCode)
                .HasMaxLength(200);

            this.Property(t => t.EvaluateDate)
                .HasMaxLength(200);

            this.Property(t => t.EvaluateEmpCode)
                .HasMaxLength(200);

            this.Property(t => t.EvaluateContent)
                .HasMaxLength(400);

            // Table & Column Mappings
            this.ToTable("YwDiseaseEvaluate");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.RecordCode).HasColumnName("RecordCode");
            this.Property(t => t.DiseaseCode).HasColumnName("DiseaseCode");
            this.Property(t => t.EvaluateCode).HasColumnName("EvaluateCode");
            this.Property(t => t.EvaluateDate).HasColumnName("EvaluateDate");
            this.Property(t => t.EvaluateEmpCode).HasColumnName("EvaluateEmpCode");
            this.Property(t => t.EvaluateCls).HasColumnName("EvaluateCls");
            this.Property(t => t.EvaluateContent).HasColumnName("EvaluateContent");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");

            // Relationships
            this.HasOptional(t => t.YwDiseaseRecord)
                .WithMany(t => t.YwDiseaseEvaluates)
                .HasForeignKey(d => d.RecordCode);

        }
    }
}