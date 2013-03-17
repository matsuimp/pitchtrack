using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
    }
}
