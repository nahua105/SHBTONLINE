//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// <copyright file="PUBGInfo.cs">
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
    /// [PUBGInfo]
    /// </summary>
    [Serializable]
    public partial class PUBGInfo 
    {
        /// <summary>
        /// [ID]
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// [PUBGID]
        /// </summary>
        public string PUBGID { get; set; }
        /// <summary>
        /// [chicken_count]
        /// </summary>
        public Nullable<int> chicken_count { get; set; }
        /// <summary>
        /// [KD]
        /// </summary>
        public Nullable<decimal> KD { get; set; }
        /// <summary>
        /// [kill_count]
        /// </summary>
        public Nullable<decimal> kill_count { get; set; }
        /// <summary>
        /// [chicken_rate]
        /// </summary>
        public Nullable<decimal> chicken_rate { get; set; }
        /// <summary>
        /// [ten_rate]
        /// </summary>
        public Nullable<decimal> ten_rate { get; set; }
        /// <summary>
        /// [headshoot_rate]
        /// </summary>
        public Nullable<decimal> headshoot_rate { get; set; }
        /// <summary>
        /// [damage]
        /// </summary>
        public Nullable<decimal> damage { get; set; }
        /// <summary>
        /// [livetime]
        /// </summary>
        public Nullable<decimal> livetime { get; set; }
        /// <summary>
        /// [run]
        /// </summary>
        public Nullable<decimal> run { get; set; }
    }
}
