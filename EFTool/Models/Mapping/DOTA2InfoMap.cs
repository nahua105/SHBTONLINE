	
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// <copyright file="DOTA2Info.cs">
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
    public class DOTA2InfoMap : EntityTypeConfiguration<DOTA2Info>
    {
        public DOTA2InfoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(36);

            this.Property(t => t.DOTA2ID)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("DOTA2Info");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DOTA2ID).HasColumnName("DOTA2ID");
            this.Property(t => t.d).HasColumnName("d");
            this.Property(t => t.damage).HasColumnName("damage");
            this.Property(t => t.gpm).HasColumnName("gpm");
            this.Property(t => t.kda).HasColumnName("kda");
            this.Property(t => t.last_hits).HasColumnName("last_hits");
            this.Property(t => t.match_count).HasColumnName("match_count");
            this.Property(t => t.pv_all).HasColumnName("pv_all");
            this.Property(t => t.pv_damage).HasColumnName("pv_damage");
            this.Property(t => t.pv_deatch).HasColumnName("pv_deatch");
            this.Property(t => t.pv_growth).HasColumnName("pv_growth");
            this.Property(t => t.pv_kda).HasColumnName("pv_kda");
            this.Property(t => t.pv_tower).HasColumnName("pv_tower");
            this.Property(t => t.win_rate).HasColumnName("win_rate");
            this.Property(t => t.xpm).HasColumnName("xpm");
        }
    }
}
