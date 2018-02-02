//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// <copyright file="BsStationLubricator.cs">
//        Copyright(c)2015   rights reserved.
//        CLR版本：4.0.30319.239
//        开发组织：李文学@上海同岩土木科技工程有限公司
//        所属工程：TY.*
//        生成时间：2016-12-15 09:53
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
    /// [BsStationLubricator]
    /// </summary>
    [Serializable]
    public partial class BsStationLubricator : BaseEntity
    {
        /// <summary>
        /// [Id]
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// [EquipmentId]
        /// </summary>
        public string EquipmentId { get; set; }
        /// <summary>
        /// [EquipmentCode]
        /// </summary>
        public string EquipmentCode { get; set; }
        /// <summary>
        /// [InstallMileage]
        /// </summary>
        public Nullable<decimal> InstallMileage { get; set; }
        /// <summary>
        /// [InstallPosition]
        /// </summary>
        public Nullable<int> InstallPosition { get; set; }
        /// <summary>
        /// [InstallDate]
        /// </summary>
        public Nullable<System.DateTime> InstallDate { get; set; }
        /// <summary>
        /// [UserDate]
        /// </summary>
        public Nullable<System.DateTime> UserDate { get; set; }
        /// <summary>
        /// [CurveLength]
        /// </summary>
        public Nullable<int> CurveLength { get; set; }
        /// <summary>
        /// [CurveRadius]
        /// </summary>
        public string CurveRadius { get; set; }
        /// <summary>
        /// [OilTimes]
        /// </summary>
        public Nullable<decimal> OilTimes { get; set; }
        /// <summary>
        /// [Oilproportion]
        /// </summary>
        public Nullable<decimal> Oilproportion { get; set; }
        /// <summary>
        /// [OilOutletPlateType]
        /// </summary>
        public string OilOutletPlateType { get; set; }
        /// <summary>
        /// [SensorMode]
        /// </summary>
        public string SensorMode { get; set; }
        /// <summary>
        /// [InspectionCycle]
        /// </summary>
        public string InspectionCycle { get; set; }
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
        /// 导航属性：BsFacilityEquipment
        /// </summary>
        public virtual BsFacilityEquipment BsFacilityEquipment { get; set; }
    }
}