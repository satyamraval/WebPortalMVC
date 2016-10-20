using System.Web;
using System.Web.Optimization;

namespace WebPortalMVC
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Content/template/plugins/jQuery/jquery-2.2.3.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/content/template/bootstrap/js/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/slimscroll").Include("~/content/template/plugins/slimScroll/jquery.slimscroll.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/fastclick").Include("~/content/template/plugins/fastclick/fastclick.js"));
            bundles.Add(new ScriptBundle("~/bundles/admin").Include("~/content/template/dist/js/app.min.js", "~/content/template/dist/js/demo.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include("~/content/template/bootstrap/bootstrap.min.css"));
            bundles.Add(new StyleBundle("~/Content/admin").Include("~/content/template/dist/css/admin.min.css"));
            bundles.Add(new StyleBundle("~/Content/skin").Include("~/content/template/dist/css/skins/_all-skins.min.css"));
            bundles.Add(new StyleBundle("~/Content/icons").Include("~/content/template/dist/css/fontawsome.min.css", "~/content/template/dist/css/ionicon.min.css"));
            
        }
    }
}