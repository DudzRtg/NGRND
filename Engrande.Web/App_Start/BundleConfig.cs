using System.Web;
using System.Web.Optimization;

namespace Engrande.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/foundation/css").Include(
                        "~/Content/DataTables/css//jquery.dataTables.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/foundation/js").Include(
                        "~/Scripts/DataTables/jquery.dataTables.js"));

            #region Foundation Bundles

            bundles.Add(Foundation.Styles());

            bundles.Add(Foundation.Scripts());

            #endregion
        }
    }
}