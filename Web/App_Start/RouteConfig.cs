using System.Web.Mvc;
using System.Web.Routing;

namespace pitchtrack
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			// only temporary until i put some more pages in here
			routes.MapRoute("Root", string.Empty, new { controller = "Game", action = "Edit", id = string.Empty });
			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new {controller = "Home", action = "Index", id = UrlParameter.Optional});

			
			
		}
	}
}