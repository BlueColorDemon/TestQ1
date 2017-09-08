using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQGT_Web.Utils
{
    /// <summary>
    /// 顶级菜单模型
    /// </summary>
    public class TopMenuModel
    {
        public TopMenuModel()
        {
            children = new HashSet<MenuModel>();
        }

        /// <summary>
        /// 
        /// </summary>
        public string path { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string component { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string iconClass { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ICollection<MenuModel> children { get; set; }
    }

    /// <summary>
    /// 二级菜单模型
    /// </summary>
    public class MenuModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string path { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string component { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string imgUrl { get; set; }
    }

}