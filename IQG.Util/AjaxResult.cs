using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQG.Util
{
    /// <summary>
    /// Ajax 结果
    /// </summary>
    public class AjaxResult
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// 消息
        /// </summary>
        public string Msg { get; set; } = AjaxMsg.Defult.Success;
        /// <summary>
        /// 数据
        /// </summary>
        public object Body { get; set; }
    }

    /// <summary>
    /// Ajax消息
    /// </summary>
    public static class AjaxMsg
    {
        /// <summary>
        /// 默认操作
        /// </summary>
        public struct Defult
        {
            /// <summary>
            /// 操作 成功
            /// </summary>
            public static readonly string Success = "操作 成功";
            /// <summary>
            /// 操作 失败
            /// </summary>
            public static readonly string Error = "操作 失败";
        }
        /// <summary>
        /// 数据加载
        /// </summary>
        public struct List
        {
            /// <summary>
            /// 数据加载 成功
            /// </summary>
            public static readonly string Success = "数据加载 成功";
            /// <summary>
            /// 数据加载 失败
            /// </summary>
            public static readonly string Error = "数据加载 失败";
        }
        /// <summary>
        /// 新增
        /// </summary>
        public struct Add
        {
            /// <summary>
            /// 新增 成功
            /// </summary>
            public static readonly string Success = "新增 成功";
            /// <summary>
            /// 新增 失败
            /// </summary>
            public static readonly string Error = "新增 失败";
        }
        /// <summary>
        /// 修改
        /// </summary>
        public struct Edit
        {
            /// <summary>
            /// 修改 成功
            /// </summary>
            public static readonly string Success = "修改 成功";
            /// <summary>
            /// 修改 失败
            /// </summary>
            public static readonly string Error = "修改 失败";
        }
        /// <summary>
        /// 删除
        /// </summary>
        public struct Remove
        {
            /// <summary>
            /// 删除 成功
            /// </summary>
            public static readonly string Success = "删除 成功";
            /// <summary>
            /// 删除 失败
            /// </summary>
            public static readonly string Error = "删除 失败";
        }

    }

}