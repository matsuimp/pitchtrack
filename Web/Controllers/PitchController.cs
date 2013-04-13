using System;
using System.Web.Mvc;

namespace Pitchtrack.Web.Controllers
{
	public class PitchController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Create(Guid gameId,
		                           Guid pitcherId,
		                           string attributes)
		{
			return null;
		}

		public ActionResult Update(string attributes)
		{
			return null;
		}

		public ActionResult Delete(Guid pitchId)
		{
			return null;
		}
	}

	

}