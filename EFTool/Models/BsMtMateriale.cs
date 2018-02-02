//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// <copyright file="BsMtMateriale.cs">
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
    /// [BsMtMateriale]
    /// </summary>
    [Serializable]
    public partial class BsMtMateriale : BaseEntity
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public BsMtMateriale()
        {
            this.BsMtBuyHistories = new List<BsMtBuyHistory>();
            this.BsMtInventories = new List<BsMtInventory>();
            this.BsMtInvokes = new List<BsMtInvoke>();
            this.BsMtReservoirs = new List<BsMtReservoir>();
            this.BsMtPurchases = new List<BsMtPurchase>();
        }

        /// <summary>
        /// [Id]
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// [MtTypeId]
        /// </summary>
        public string MtTypeId { get; set; }
        /// <summary>
        /// [MtTypeCode]
        /// </summary>
        public string MtTypeCode { get; set; }
        /// <summary>
        /// [MaterialCode]
        /// </summary>
        public string MaterialCode { get; set; }
        /// <summary>
        /// [MaterialModeller]
        /// </summary>
        public string MaterialModeller { get; set; }
        /// <summary>
        /// [MaterialUnitName]
        /// </summary>
        public string MaterialUnitName { get; set; }
        /// <summary>
        /// [Maleenhed]
        /// </summary>
        public Nullable<decimal> Maleenhed { get; set; }
        /// <summary>
        /// [MaterialBrand]
        /// </summary>
        public string MaterialBrand { get; set; }
        /// <summary>
        /// [Teknologi]
        /// </summary>
        public string Teknologi { get; set; }
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
        /// 导航集合：BsMtBuyHistories
        /// </summary>
        public virtual ICollection<BsMtBuyHistory> BsMtBuyHistories { get; set; }
        /// <summary>
        /// 导航属性：BsMtCategory
        /// </summary>
        public virtual BsMtCategory BsMtCategory { get; set; }
        /// <summary>
        /// 导航集合：BsMtInventories
        /// </summary>
        public virtual ICollection<BsMtInventory> BsMtInventories { get; set; }
        /// <summary>
        /// 导航集合：BsMtInvokes
        /// </summary>
        public virtual ICollection<BsMtInvoke> BsMtInvokes { get; set; }
        /// <summary>
        /// 导航集合：BsMtReservoirs
        /// </summary>
        public virtual ICollection<BsMtReservoir> BsMtReservoirs { get; set; }
        /// <summary>
        /// 导航集合：BsMtPurchases
        /// </summary>
        public virtual ICollection<BsMtPurchase> BsMtPurchases { get; set; }
    }
}