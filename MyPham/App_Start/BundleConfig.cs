using System.Web;
using System.Web.Optimization;

namespace MyPham
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));



            bundles.Add(new ScriptBundle("~/bundles/js_them1").Include(
                      "~/Scripts/js/vendor/jquery-1.12.0.min.js",
                      "~/Scripts/js/bootstrap.min.js",
                      "~/Scripts/js/plugins.js",
                      "~/Scripts/js/slick.min.js",
                      "~/Scripts/js/owl.carousel.min.js",
                      "~/Scripts/js/waypoints.min.js",
                      "~/Scripts/main.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css_them1").Include(
                       "~/Content/css/bootstrap.min.css",
                       "~/Content/css/owl.carousel.min.css",
                       "~/Content/css/owl.theme.default.min.css",
                       "~/Content/css/core.css",
                       "~/Content/css/shortcode/shortcodes.css",
                       "~/Content/style.css",
                       "~/Content/css/responsive.css",
                       "~/Content/css/responsive.css",
                       "~/Content/css/custom.css"));
        }
    }
}
