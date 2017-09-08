using BC.CommonConfig;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace IQGT_Web.Utils
{
    /// <summary>
    /// 应用程序配置
    /// </summary>
    public class Appsettings
    {
        /// <summary>
        /// 默认菜单配置文件路径
        /// </summary>
        public static string DefaultMenuConfig
        {
            get { return FileUtility.GetPhysicalPath(ConfigurationManager.AppSettings["DefaultMenuConfig"]); }
        }
    }
}