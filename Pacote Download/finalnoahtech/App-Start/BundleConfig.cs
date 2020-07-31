using System.Web;
using System.Web.Optimization;


namespace Noahtech.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Script/jquery.(version).js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Script/jquery.validate"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Script/modernizr"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Script/bootstrap.js", "~/Script/respond.js"));

            bundles.Add(new ScriptBundle("~/Content/css").Include(
                "~/Content/bootstrap.css" , "~/Content/site.css"));


            #region Template Desing

            bundles.Add(new ScriptBundle("~/template/js").Include(
                "~/Script/jquery.validate"));


            bundles.Add(new ScriptBundle("~/template/css").Include(
                "~/Content/css/bootstrap.min.css",
                "~/Content/css/pogo-slider.min.css",
                "~/Content/css/style.min.css",
                "~/Content/css/responsive.min.css",
                "~/Content/css/custom.min.css"
                    ));

            #endregion
        }
    }
}
