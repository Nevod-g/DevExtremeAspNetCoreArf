using DevExtremeAspNetCoreArf.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevExtremeAspNetCoreArf.Controllers
{
    public class ArfController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            System.Diagnostics.Debug.WriteLine("ValidationController.Overview()");
            return View(new ArfViewModel
            {
                ITAR = true,
                ContactName = "Peter"
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ArfViewModel arfInfo)
        {
            System.Diagnostics.Debug.WriteLine("ValidationController.Overview(arfInfo)");
            if (ModelState.IsValid)
            {
                return View("SuccessValidation");
            }

            return View(arfInfo);
        }

        [HttpPost]
        public JsonResult CheckEmailAddress(string email)
        {
            System.Diagnostics.Debug.WriteLine("ValidationController.CheckEmailAddress");
            bool isValid = string.Equals(email, "test@test.com", StringComparison.OrdinalIgnoreCase);
            return Json(isValid);
        }
    }
}