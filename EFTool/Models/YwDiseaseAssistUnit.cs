//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// <copyright file="YwDiseaseAssistUnit.cs">
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
    /// [YwDiseaseAssistUnit]
    /// </summary>
    [Serializable]
    public partial class YwDiseaseAssistUnit : BaseEntity
    {
        /// <summary>
        /// [Id]
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// [PlanId]
        /// </summary>
        public string PlanId { get; set; }
        /// <summary>
        /// [PlanCode]
        /// </summary>
        public string PlanCode { get; set; }
        /// <summary>
        /// [UnitConfigCode]
        /// </summary>
        public string UnitConfigCode { get; set; }
        /// <summary>
        /// [AssistUnitId]
        /// </summary>
        public string AssistUnitId { get; set; }
        /// <summary>
        /// [AssistRequire]
        /// </summary>
        public string AssistRequire { get; set; }
        /// <summary>
        /// [Remark]
        /// </summary>
        public string Remark { get; set; }
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
        /// 导航属性：YwDiseasePlan
        /// </summary>
        public virtual YwDiseasePlan YwDiseasePlan { get; set; }
    }
}