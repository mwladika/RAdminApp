﻿using System;
using System.Web.Mvc;
using System.Threading.Tasks;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using RAdminApp.Models;

namespace RAdminApp.Controllers
{
    public class ProductionSeasonsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: ProductionSeasons
        public async Task<ActionResult> ProductionSeasonsRead([DataSourceRequest]DataSourceRequest request)
        {
            var tessituraService = TessAuthClass.GetTessituraService(Session["TessPath"].ToString());

            var Response = await tessituraService.Txn.ProductionSeasons.GetAll();
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
