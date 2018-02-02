//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// <copyright file="BsFacilityPart.cs">
//        Copyright(c)2015   rights reserved.
//        CLR版本：4.0.30319.239
//        开发组织：李文学@上海同岩土木科技工程有限公司
//        所属工程：TY.*
//        生成时间：2016-12-15 09:52
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using TY.Framework.EF;
using TY.Framework.EF.Base;
using TY.Framework.ToolT4;


namespace TY.SHMetroPlan.Data.Domain.Models
{
    /// <summary>
    /// [BsFacilityPart]
    /// </summary>
    [Serializable]
    public partial class BsFacilityPart : BaseEntity
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public BsFacilityPart()
        {
            this.BsFacilityDiseases = new List<BsFacilityDisease>();
            this.BsFacilityPart1 = new List<BsFacilityPart>();
        }

        /// <summary>
        /// [Id]
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// [FacilityTypeId]
        /// </summary>
        public string FacilityTypeId { get; set; }
        /// <summary>
        /// [FacilityTypeCode]
        /// </summary>
        public string FacilityTypeCode { get; set; }
        /// <summary>
        /// [FacilityLocation]
        /// </summary>
        public Nullable<int> FacilityLocation { get; set; }
        /// <summary>
        /// [FacilityPartCode]
        /// </summary>
        public string FacilityPartCode { get; set; }
        /// <summary>
        /// [FacilityPartName]
        /// </summary>
        public string FacilityPartName { get; set; }
        /// <summary>
        /// [ParentId]
        /// </summary>
        public string ParentId { get; set; }
        /// <summary>
        /// [ParentCode]
        /// </summary>
        public string ParentCode { get; set; }
        /// <summary>
        /// [IsEnabled]
        /// </summary>
        public Nullable<int> IsEnabled { get; set; }
        /// <summary>
        /// [Remark]
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// [SortId]
        /// </summary>
        public Nullable<int> SortId { get; set; }
        /// <summary>
        /// [CreateTime]
        /// </summary>
        public Nullable<System.DateTime> CreateTime { get; set; }
        /// <summary>
        /// [UpdateTime]
        /// </summary>
        public Nullable<System.DateTime> UpdateTime { get; set; }
        /// <summary>
        /// [RowVersion]
        /// </summary>
        public Nullable<int> RowVersion { get; set; }
        /// <summary>
        /// 导航属性：BsFacilityCatetory
        /// </summary>
        public virtual BsFacilityCatetory BsFacilityCatetory { get; set; }
        /// <summary>
        /// 导航集合：BsFacilityDiseases
        /// </summary>
        public virtual ICollection<BsFacilityDisease> BsFacilityDiseases { get; set; }
        /// <summary>
        /// 导航集合：BsFacilityPart1
        /// </summary>
        public virtual ICollection<BsFacilityPart> BsFacilityPart1 { get; set; }
        /// <summary>
        /// 导航属性：BsFacilityPart2
        /// </summary>
        public virtual BsFacilityPart BsFacilityPart2 { get; set; }
    }
}