using System.Web.Optimization;

namespace pitchtrack
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.UseCdn = true;

			bundles.Add(new ScriptBundle("~/bundles/jquery", "//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js").Include("~/Scripts/jquery-{version}.js"));
			bundles.Add(new ScriptBundle("~/bundles/handlebars", "//cdnjs.cloudflare.com/ajax/libs/handlebars.js/1.0.0-rc.3/handlebars.min.js").Include("~/Scripts/handlebars.js"));
			bundles.Add(new ScriptBundle("~/bundles/pitchtrack-utils").Include("~/Scripts/PitchTrack.UriFormat.js"));
		}
	}
}