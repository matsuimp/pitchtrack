using System.Web.Http;

namespace pitchtrack
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new {id = RouteParameter.Optional}
				);

			config.Routes.MapHttpRoute(
				name: "GetAttributeRoot",
				routeTemplate: "attribute/root/{rootIds}",
				defaults: new {controller = "attribute", action = "GetRoots", rootIds = RouteParameter.Optional});
		}
	}
}