using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
//using DevExtremeAspNetCoreArf.Models.DataGrid;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json.Linq;

namespace DevExtremeAspNetCoreArf.Controllers
{
    public class RemoteValidationController : Controller
    {
        //InMemoryEmployeesValidationDataContext _db;

        //public RemoteValidationController(IHttpContextAccessor httpContextAccessor, IMemoryCache memoryCache)
        //{
        //    _db = new InMemoryEmployeesValidationDataContext(httpContextAccessor, memoryCache);
        //}

        //[HttpPost]
        //public JsonResult CheckUniqueEmailAddress([FromBody] JObject data)
        //{
        //    int? id = (int?)data["id"];
        //    string email = data["email"].ToString();
        //    bool isValid = !_db.Employees.Any(emp => {
        //        bool isEqual = string.Equals(emp.Email, email, StringComparison.OrdinalIgnoreCase);
        //        return id != null ? id != emp.ID && isEqual : isEqual;
        //    });
        //    return Json(isValid);
        //}

        [HttpPost]
        public JsonResult CheckEmailAddress(string email)
        {
            System.Diagnostics.Debug.WriteLine(email);
            bool isValid = string.Equals(email, "test@dx-email.com", StringComparison.OrdinalIgnoreCase);
            return Json(isValid);
        }

        [HttpPost]
        public JsonResult VerifyCheckBox(bool? classifiedOrControlled)
        {
            //выполняется только когда установлен флаг, значение в параметре не передаётся
            System.Diagnostics.Debug.WriteLine("RemoteValidationController.VerifyCheckBox");

            bool isValid = classifiedOrControlled != null;
            return Json(isValid);
        }
    }
}