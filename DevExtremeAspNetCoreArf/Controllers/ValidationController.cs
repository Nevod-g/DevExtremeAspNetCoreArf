using DevExtremeAspNetCoreArf.ViewModels;
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
            return View(new EditorsViewModel
            {
                ContactName = "Peter"
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Overview(EditorsViewModel userInfo)
        {
            if (ModelState.IsValid)
            {
                return View("SuccessValidation");
            }

            return View(userInfo);
        }

        [HttpPost]
        public JsonResult CheckEmailAddress(string email)
        {
            bool isValid = string.Equals(email, "test@test.com", StringComparison.OrdinalIgnoreCase);
            return Json(isValid);
        }
    }
}
