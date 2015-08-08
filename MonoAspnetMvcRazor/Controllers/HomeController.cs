using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace MonoAspnetMvcRazor.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			var mvcName = typeof(Controller).Assembly.GetName ();
			var isMono = Type.GetType ("Mono.Runtime") != null;

			ViewData ["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData ["Runtime"] = isMono ? "Mono" : ".NET";

			using (var entities = new DatabaseContext ()) {
				entities.Histories.Add (new History () {
					IPAddress = this.Request.UserHostAddress,
					VisitTime = DateTime.Now,
					Uri = this.Request.Url.AbsoluteUri
				});
				entities.SaveChanges ();
			}

			return View ();
		}
	}
}

