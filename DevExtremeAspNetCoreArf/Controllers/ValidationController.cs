using DevExtremeAspNetCoreArf.ViewModels;
using DevExtremeAspNetCoreArf.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevExtremeAspNetCoreArf.Controllers
{
    public class ValidationController : Controller
    {
        [HttpGet]
        public ActionResult Overview()
        {
            return View(new ArfViewModel
            {
                ContactName = "Peter"
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Overview(ArfViewModel arfInfo)
        {
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
