using Newtonsoft.Json;
//using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IQGT_Web.Utils
{
    /// <summary>
    /// App-菜单
    /// </summary>
    public class AppMenu
    {
        //private static Logger logger = LogManager.GetCurrentClassLogger();

        public static string serverPath = System.AppDomain.CurrentDomain.BaseDirectory;

        public static string GetMenuList()
        {
            var topMenuList = new List<TopMenuModel>();
            topMenuList = ReadSchoolAppJpushConfig();

            //var topMenu1 = new TopMenuModel() { component = "", name = "Dashboard", path = "", iconClass = "el-icon-message" };
            //var menu1_1 = new MenuModel() { component = "", name = "主页", path = "", imgUrl = "" };
            //var menu1_2 = new MenuModel() { component = "", name = "关于", path = "", imgUrl = "" };
            //var menu1_3 = new MenuModel() { component = "", name = "联系人", path = "", imgUrl = "" };
            //topMenu1.children.Add(menu1_1);
            //topMenu1.children.Add(menu1_2);
            //topMenu1.children.Add(menu1_3);

            //var topMenu2 = new TopMenuModel() { component = "", name = "项目-Dashboard", path = "", iconClass = "el-icon-message" };
            //var menu2_1 = new MenuModel() { component = "", name = "项目-报表1", path = "", imgUrl = "" };
            //var menu2_2 = new MenuModel() { component = "", name = "项目-报表2", path = "", imgUrl = "" };
            //topMenu2.children.Add(menu2_1);
            //topMenu2.children.Add(menu2_2);

            //var topMenu3 = new TopMenuModel() { component = "", name = "投资者-Dashboard", path = "", iconClass = "el-icon-message" };
            //var menu3_1 = new MenuModel() { component = "", name = "投资者-报表1", path = "", imgUrl = "" };
            //var menu3_2 = new MenuModel() { component = "", name = "投资者-报表2", path = "", imgUrl = "" };
            //topMenu3.children.Add(menu3_1);
            //topMenu3.children.Add(menu3_2);

            //topMenuList.Add(topMenu1);
            //topMenuList.Add(topMenu2);
            //topMenuList.Add(topMenu3);

            var json = JsonConvert.SerializeObject(topMenuList);
            return json;
        }

        /// <summary>
        /// 读取 默认菜单 配置
        /// </summary>
        /// <returns></returns>
        public static List<TopMenuModel> ReadSchoolAppJpushConfig()
        {
            List<TopMenuModel> result = null;
            try
            {
                string filePaht = Path.Combine(serverPath, Appsettings.DefaultMenuConfig);
                using (StreamReader file = File.OpenText(filePaht))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    result = (List<TopMenuModel>)serializer.Deserialize(file, typeof(List<TopMenuModel>));
                }
            }
            catch (Exception ex)
            {
                //logger.Error($"错误信息:{ex.Message}");
                //BC.CommonConfig.LogUtil.WriteLogFile(ex.Message, "ReadConfig.log");
            }
            return result;
        }

        public static string activeMenu()
        {
            string activeMenu = HttpContext.Current.Request["activeMenu"];
            if (activeMenu != null)
            {
                return activeMenu;
            }
            else
            {
                return "IQG项目-首页";
            }
        }

        public static string openedsMenu()
        {
            string openedsMenu = HttpContext.Current.Request["openedsMenu"];
            if (openedsMenu != null)
            {
                return openedsMenu;
            }
            else
            {
                return "TradeProjects";
            }
        }



    }
}