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

using System;
using System.Collections.Generic;
using Data.Domain;
using Data.DomainMap;


//namespace TM.Data.Models
namespace  Data.Domain
{
    /// <summary>
    /// [DOTA2Info]
    /// </summary>
    [Serializable]
    public partial class DOTA2Info 
    {
        /// <summary>
        /// [ID]
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// [DOTA2ID]
        /// </summary>
        public string DOTA2ID { get; set; }
        /// <summary>
        /// [d]
        /// </summary>
        public Nullable<decimal> d { get; set; }
        /// <summary>
        /// [damage]
        /// </summary>
        public Nullable<decimal> damage { get; set; }
        /// <summary>
        /// [gpm]
        /// </summary>
        public Nullable<decimal> gpm { get; set; }
        /// <summary>
        /// [kda]
        /// </summary>
        public Nullable<decimal> kda { get; set; }
        /// <summary>
        /// [last_hits]
        /// </summary>
        public Nullable<decimal> last_hits { get; set; }
        /// <summary>
        /// [match_count]
        /// </summary>
        public Nullable<int> match_count { get; set; }
        /// <summary>
        /// [pv_all]
        /// </summary>
        public Nullable<decimal> pv_all { get; set; }
        /// <summary>
        /// [pv_damage]
        /// </summary>
        public Nullable<decimal> pv_damage { get; set; }
        /// <summary>
        /// [pv_deatch]
        /// </summary>
        public Nullable<decimal> pv_deatch { get; set; }
        /// <summary>
        /// [pv_growth]
        /// </summary>
        public Nullable<decimal> pv_growth { get; set; }
        /// <summary>
        /// [pv_kda]
        /// </summary>
        public Nullable<decimal> pv_kda { get; set; }
        /// <summary>
        /// [pv_tower]
        /// </summary>
        public Nullable<decimal> pv_tower { get; set; }
        /// <summary>
        /// [win_rate]
        /// </summary>
        public Nullable<decimal> win_rate { get; set; }
        /// <summary>
        /// [xpm]
        /// </summary>
        public Nullable<decimal> xpm { get; set; }
    }
}
