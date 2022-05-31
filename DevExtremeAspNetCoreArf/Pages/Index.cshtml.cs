using DevExtremeAspNetCoreArf.Models;
using DevExtremeAspNetCoreArf.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace DevExtremeAspNetCoreArf.Pages
{
    public class IndexModel : PageModel
    {
        public readonly Arf Arf = new(); //Заявка клиента
        public string ArfJsonString => JsonSerializer.Serialize(Arf);

        private readonly IArfRepository db;

        public IndexModel(IArfRepository db)
        {
            this.db = db;
        }

        public IEnumerable<Arf> ArfList { get; set; }        

        public IActionResult OnGet()
        {
            
            ArfList = db.GetAllArf();
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return RedirectToPage("SuccessValidation");
            }
            else
            {
                return Page();
            }
        }

        public void OnGetMyOnClick()
        {
            Debug.Print("Hello");
        }

        public FileContentResult GetFile()
        {
            byte[] fileContent = Encoding.UTF8.GetBytes(ArfJsonString);
            string fileType = "text/json";
            string fileName = "arf.json";

            return File(fileContent, fileType, fileName);
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
