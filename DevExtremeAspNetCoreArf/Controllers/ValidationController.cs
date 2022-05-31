using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevExtremeAspNetCoreArf.Controllers
{
    public class ValidationController : Controller
    {
        [HttpPost]
        public JsonResult VerifyCheckBox(bool isChecked)
        {
            Debug.Print(isChecked.ToString());
            //Debug.Print($"{nameof(VerifyCheckBox)}: {isChecked}");
            return Json(isChecked);
        }

        [HttpPost]
        public JsonResult CheckEmailAddress(string email)
        {
            bool isValid = string.Equals(email, "test@dx-email.com", StringComparison.OrdinalIgnoreCase);
            return Json(isValid);
        }

        [HttpPost]
        public JsonResult CheckNoExistingProcess(bool isChecked)
        {
            Debug.Print(isChecked.ToString());
            return Json(true);
        }
    }
}