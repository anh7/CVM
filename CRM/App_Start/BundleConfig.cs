using System.Web;
using System.Web.Optimization;

namespace CRM
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/stylesheets/css").Include(
                       "~/Content/stylesheets/bootstrap.min.css",
                      "~/Content/stylesheets/isotope.css",
                      "~/Content/stylesheets/normalize.css",
                      "~/Content/stylesheets/fullcalendar.css",
                      "~/Content/stylesheets/datatables.css",
                      "~/Content/stylesheets/prettify.css",
                       "~/Content/stylesheets/classyscroll.css",
                       "~/Content/stylesheets/jquery.fancybox.css",
                       //"~/Content/stylesheets/css/listbox.css",
                       //"~/Content/stylesheets/select2.css",
                       "~/Content/xeditable/css/select2.css",

                       "~/Content/stylesheets/fontawesome.css",
                       "~/Content/stylesheets/uniform.default.css",
                       "~/Content/stylesheets/style.css",
                       "~/Content/stylesheets/customize.css",
                       "~/Content/xeditable/css/bootstrap-editable.css",
                       //"~/Content/stylesheets/color/green.css",
                       //"~/Content/stylesheets/color/orange.css",
                //"~/Content/stylesheets/color/magenta.css",
                       //"~/Content/stylesheets/color/gray.css",
                       "~/Content/stylesheets/customize.css",
                       "~/Content/stylesheets/customize_cp.css",
                    "~/Content/xeditable/address/address.css"
                       ));
            bundles.Add(new ScriptBundle("~/Script/javascripts").Include(
                    "~/Scripts/javascripts/modernizr.custom.js",
                    //"~/Scripts/javascripts/bootstrap.min.js",
                    "~/Scripts/javascripts/jquery.mousewheel.js",
                    "~/Scripts/javascripts/jquery.classyscroll.js",
                    //"~/Scripts/javascripts/jquery.vmap.min.js",
                    //"~/Scripts/javascripts/jquery.vmap.sampledata.js",
                    //"~/Scripts/javascripts/jquery.vmap.world.js",
                    //"~/Scripts/javascripts/fullcalendar.min.js",
                    //"~/Scripts/javascripts/gcal.js",
                    //"~/Scripts/javascripts/prettify.js",
                    "~/Scripts/javascripts/jquery.dataTables.min.js",
                    "~/Scripts/javascripts/jquery.fancybox.pack.js",
                    "~/Scripts/jquery.validate.min.js",
                    "~/Scripts/jquery.validate.js",
                    //"~/Scripts/javascripts/excanvas.min.js",
                    //"~/Scripts/javascripts/jquery.isotope.min.js",
                    //"~/Scripts/javascripts/select2.js",
                    //"~/Scripts/jquery.ui.widget.js",
                    //"~/Scripts/jquery.fileupload.js",
                    "~/Scripts/javascripts/styleswitcher.js",
                    "~/Scripts/javascripts/jquery.uniform.js",
                     "~/Scripts/javascripts/listbox.js",
                    "~/Scripts/javascripts/main.js",
                    "~/Content/xeditable/js/select2.min.js"
                    ));
        }
    }
}