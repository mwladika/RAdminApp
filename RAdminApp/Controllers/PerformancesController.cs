using System;
using System.Web.Mvc;
using System.Threading.Tasks;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using RAdminApp.Models;
using Tessitura.Service.Contract;

namespace RAdminApp.Controllers
{
    public class PerformancesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: Performances
        public async Task<ActionResult> PerformancesRead([DataSourceRequest]DataSourceRequest request)
        {
            var tessituraService = TessAuthClass.GetTessituraService(Session["TessPath"].ToString());

            //Search gives back a different data set
            //var sr = new PerformanceSearchRequest();
            //sr.PerformanceStartDate = DateTime.Now;
            //var Response = await tessituraService.Txn.Performances.Search(sr);

            var Response = await tessituraService.Txn.Performances.GetSummaries();


            if (Response.ErrorMessages != null)
            {
                ViewBag.errmessage = Response.ErrorMessages.ToString();
                return View(); 
            }
            else
            {
                var result = Response.ResponseObject;
                return Json(result.ToDataSourceResult(request));
            }
        }

    }
}
