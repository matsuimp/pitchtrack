using System.Web.Optimization;

namespace pitchtrack
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.UseCdn = true;

			bundles.Add(new ScriptBundle("~/bundles/jquery", "//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js").Include("~/Content/Scripts/jquery-{version}.js"));
			bundles.Add(new ScriptBundle("~/bundles/handlebars", "//cdnjs.cloudflare.com/ajax/libs/handlebars.js/1.0.0-rc.3/handlebars.min.js").Include("~/Content/Scripts/handlebars.js"));
			bundles.Add(new ScriptBundle("~/bundles/pitchtrack-utils").Include("~/Content/Scripts/PitchTrack.UriFormat.js"));
			bundles.Add(new StyleBundle("~/Content/Styles/stylesheets").IncludeDirectory("~/Content/Styles/stylesheets", "*.css"));
		}
	}
}