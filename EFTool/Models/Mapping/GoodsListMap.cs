	
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// <copyright file="GoodsList.cs">
//        Copyright(c)2015   rights reserved.
//        CLR版本：4.0.30319.239
//        开发组织：李文学@上海同岩土木科技工程有限公司
//        所属工程：TY.*
//        生成时间：2018-03-23 09:42
// </copyright>
//------------------------------------------------------------------------------

	using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Data.Domain;
using Data.DomainMap;

//namespace TM.Data.Models.Mapping
namespace Data.DomainMap
    public class GoodsListMap : EntityTypeConfiguration<GoodsList>
    {
        public GoodsListMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.Type)
                .HasMaxLength(200);

            this.Property(t => t.LevelName)
                .HasMaxLength(200);

            this.Property(t => t.Comm)
                .HasMaxLength(200);

            this.Property(t => t.IMG)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("GoodsList");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Cost1).HasColumnName("Cost1");
            this.Property(t => t.Cost2).HasColumnName("Cost2");
            this.Property(t => t.LevelName).HasColumnName("LevelName");
            this.Property(t => t.Level).HasColumnName("Level");
            this.Property(t => t.Comm).HasColumnName("Comm");
            this.Property(t => t.IMG).HasColumnName("IMG");
        }
    }
}
