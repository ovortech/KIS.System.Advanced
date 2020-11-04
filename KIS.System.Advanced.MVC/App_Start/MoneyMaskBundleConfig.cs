using System.Web.Optimization;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(KIS.System.Advanced.MVC.App_Start.MoneyMaskBundleConfig), "RegisterBundles")]

namespace KIS.System.Advanced.MVC.App_Start
{
	public class MoneyMaskBundleConfig
	{
		public static void RegisterBundles()
		{
			BundleTable.Bundles.Add(new ScriptBundle("~/bundles/moneymask").Include("~/Scripts/jquery.moneymask.js"));
		}
	}
}