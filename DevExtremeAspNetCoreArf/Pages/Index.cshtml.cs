using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DevExtremeAspNetCoreArf.ViewModels;

namespace DevExtremeAspNetCoreArf.Pages {
    public class IndexModel : PageModel {

        public readonly ArfViewModel Context = new ();

        //public IndexModel(ArfViewModel context)
        //{
        //    _context = context;
        //}

        public IActionResult OnGet() {
            return Page();
        }

        // runs on the GET request
        //public IActionResult OnGetGridData(DataSourceLoadOptions loadOptions)
        //{
        //    var categories = _context.Categories.Select(i => new {
        //        i.CategoryId,
        //        i.CategoryName
        //    });
        //    return new JsonResult(DataSourceLoader.Load(categories, loadOptions));
        //}

        // runs on the PUT request
        //public IActionResult OnPutGridRow(int key, string values)
        //{
        //    var model = _context.Categories.FirstOrDefault(item => item.CategoryId == key);

        //    var _values = JsonConvert.DeserializeObject<IDictionary>(values);
        //    PopulateModel(model, _values);

        //    if (!TryValidateModel(model))
        //        return BadRequest("Validation failed");

        //    _context.SaveChanges();
        //    return new OkResult();
        //}

        // a handler for the POST request
        //...

        // a handler for the DELETE request
        //...

        //void PopulateModel(Category model, IDictionary values)
        //{
        //    if (values.Contains("CategoryName"))
        //    {
        //        model.CategoryName = Convert.ToString(values["CategoryName"]);
        //    }
        //}
    }
}
