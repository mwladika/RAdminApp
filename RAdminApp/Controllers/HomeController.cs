using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace RAdminApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string ti = Request.QueryString["ti"];

            if (ti == null || ti.Length == 0) 
            {
                Session["TessInstance"] = "TWEB_Default";
                Session["TessPath"] = ConfigurationManager.AppSettings["PathWeb"];
            } else
            {
                switch (ti)
                {
                    case "0":
                        Session["TessInstance"] = "TLIVE";
                        Session["TessPath"] = ConfigurationManager.AppSettings["PathLive"];
                        break;
                    case "1":
                        Session["TessInstance"] = "TWEB";
                        Session["TessPath"] = ConfigurationManager.AppSettings["PathWeb"];
                        break;
                    case "2":
                        Session["TessInstance"] = "TTEST";
                        Session["TessPath"] = ConfigurationManager.AppSettings["PathTest"];
                        break;
                    default:
                        Session["TessInstance"] = "TWEB_Default";
                        Session["TessPath"] = ConfigurationManager.AppSettings["PathWeb"];
                        break;
                }

            }

            return View();
        }

    }
}
