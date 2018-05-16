using GoogleApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoogleApi.Controllers
{
    public class MarkerController : Controller
    {
        List<Marker> marker = null;
        // GET: Marker
        public ActionResult Index()
        {
            return View();
        }
        public Marker Report(int x, int y)
        {
            Marker marker = new Marker()
            {
                xPosition = x,
                yPosition = y
            };
            return marker;
        }

    }
}