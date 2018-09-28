using System;
using System.Web.Mvc;
using System.Threading.Tasks;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using RAdminApp.Models;

namespace RAdminApp.Controllers
{
    public class DiagnosticsController : Controller
    {
        // GET: Diagnostics
        public ActionResult Index()
        {
            var request = new DataSourceRequest(); 
            var answer = MosRead(request);
            ViewBag.answer = answer; 
            return View();  
        }

        public async Task<string> MosRead([DataSourceRequest]DataSourceRequest request)
        {
            var tessituraService = TessAuthClass.GetTessituraService(Session["TessPath"].ToString());

            var Response = await tessituraService.DiagnosticsFacade.GetStatusReport();
            if (Response.ErrorMessages != null)
            {
                ViewBag.errmessage = Response.ErrorMessages.ToString();
                return "Error";
            }
            else
            {
                return "hi";
            }
        }
    }
}