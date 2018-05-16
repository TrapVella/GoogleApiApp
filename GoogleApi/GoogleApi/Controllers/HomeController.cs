using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoogleApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddPointResult()
        {
            //(52.22933388652788, 20.99592086918949)
            string xyLocalize = Request["ZY"].ToString();
            string xLocation = xyLocalize.Substring(1, xyLocalize.IndexOf(","));
            string yLocation = xyLocalize.Substring(xyLocalize.IndexOf(",")+2, xyLocalize.Length -1);


            decimal principle = Convert.ToDecimal(Request["txtAmount"].ToString());
            decimal rate = Convert.ToDecimal(Request["txtRate"].ToString());
            int time = Convert.ToInt32(Request["txtYear"].ToString());

            //decimal simpleInteresrt = (principle * time * rate) / 100;

            //StringBuilder sbInterest = new StringBuilder();
            //sbInterest.Append("<b>Amount :</b> " + principle + "<br/>");
            //sbInterest.Append("<b>Rate :</b> " + rate + "<br/>");
            //sbInterest.Append("<b>Time(year) :</b> " + time + "<br/>");
            //sbInterest.Append("<b>Interest :</b> " + simpleInteresrt);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public void AddPosition()
        {

        }
    }
}