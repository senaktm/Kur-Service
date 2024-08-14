using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KurMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
			using (KurServiceReference.KurServiceClient serviceClient = new KurServiceReference.KurServiceClient())
			{
				if (TempData["Kurlar"] != null)
				{
					ViewBag.Kurlar = (List<double>)TempData["Kurlar"];
				}
				else
				{
					ViewBag.Kurlar = new List<double>();
				}
				var model = serviceClient.ParaBirimleriniGetir().ToList();
				return View(model);
			}
		}
		public ActionResult KurGetir(string paraBirimi)
		{
			using (KurServiceReference.KurServiceClient serviceClient = new KurServiceReference.KurServiceClient())
			{
				var model = serviceClient.KurlariGetir(paraBirimi).ToList();
				TempData["Kurlar"] = model;
				return RedirectToAction("Index", "Home");
			}
		} 
    }
}