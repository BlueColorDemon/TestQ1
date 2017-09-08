using System.Web;
using System.Web.Optimization;

namespace TestQ1
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region 示例

            //var lessBundle = new Bundle("~/My/Less").IncludeDirectory("~/My", "*.less");
            //lessBundle.Transforms.Add(new LessTransform());
            //lessBundle.Transforms.Add(new CssMinify());
            //bundles.Add(lessBundle);

            #endregion

            #region element 框架

            bundles.Add(new StyleBundle("~/Content/global").Include(
                "~/Content/layout/_global.css"));
            bundles.Add(new StyleBundle("~/Content/layout").Include(
                "~/Content/layout/_layout.css"));

            //bundles.Add(new StyleBundle("~/Content/layout").IncludeDirectory(
            //    "~/Content/layout", "*.css"));

            bundles.Add(new StyleBundle("~/Content/element").Include(
                      "~/Content/element/theme-default/index.css"));

            bundles.Add(new ScriptBundle("~/bundles/vue").Include(
                      "~/Scripts/vue.js"));

            bundles.Add(new ScriptBundle("~/bundles/element").Include(
                      "~/Content/element/index.js"));

            bundles.Add(new ScriptBundle("~/bundles/axios").Include(
                      "~/Scripts/axios/axios.js"));

            #endregion

            #region 系统自带
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            #endregion
        }
    }
}
