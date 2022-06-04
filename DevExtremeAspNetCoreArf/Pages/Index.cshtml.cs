using DevExtremeAspNetCoreArf.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace DevExtremeAspNetCoreArf.Pages
{
    public class IndexModel : PageModel
    {
        public Models.Arf Arf = new(); //Заявка клиента
        public string ArfJsonString => JsonSerializer.Serialize(Arf);

        private readonly IArfRepository arfRepository;
        private readonly IWebHostEnvironment webHostEnviroment;

        public IndexModel(IArfRepository arfRepository, IWebHostEnvironment webHostEnviroment)
        {
            this.arfRepository = arfRepository;
            this.webHostEnviroment = webHostEnviroment;
            //Arf = arfRepository.GetArf(2);
        }

        public IActionResult OnGet() // Получение от сервера, загрузка страницы
        {
            return Page();
        }

        public IActionResult OnPost(Models.Arf arf) // Отправка на сервер, отправка страницы
        {
            this.Arf = arfRepository.Update(arf);

            Debug.Print(Arf.CompanyName);
            //return RedirectToPage("SuccessValidation");
            //if (ModelState.IsValid)
            //{
            //    return RedirectToPage("SuccessValidation");
            //}
            //else
            //{
            //    return Page();
            //}
            return Page();
        }

        public FileContentResult GetFile()
        {
            Debug.Print("GetFile");
            //string filePath = Server.MapPath;
            byte[] fileContent = Encoding.UTF8.GetBytes(ArfJsonString);
            string fileType = "text/json";
            string fileName = "arf.json";

            return File(fileContent, fileType, fileName);
        }

        public FileContentResult GetFileArf()
        {
            Debug.Print("GetFileArf");
            //string filePath = Server.MapPath;
            byte[] fileContent = Encoding.UTF8.GetBytes(ArfJsonString);
            string fileType = "text/json";
            string fileName = "arf.json";

            return File(fileContent, fileType, fileName);
        }

        public FileContentResult OnPostDownloadArfJson(Models.Arf arf)
        {
            Debug.Print(arf.CompanyName);
            this.Arf = arfRepository.Update(arf);            

            byte[] fileContent = Encoding.UTF8.GetBytes(ArfJsonString);
            string fileType = "text/json";
            string fileName = "arf.json";

            return File(fileContent, fileType, fileName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileData"></param>
        /// <param name="dirName">Destination file name.</param>
        /// <param name="fileName"></param>
        private void UploadFile(byte[] fileData, string dirName, string fileName)
        {
            string filePath = Path.Combine(webHostEnviroment.WebRootPath, dirName, fileName);
            using (var fs = new FileStream(filePath, FileMode.Create))
            {
                fs.Write(fileData, 0, fileData.Length);
            }
        } 
        
        private void DeleteFile(string dirName, string fileName)
        {
            string filePath = Path.Combine(webHostEnviroment.WebRootPath, dirName, fileName);
            System.IO.File.Delete(filePath);
        }


        // runs on the GET request
        //public IActionResult OnGetGridData(DataSourceLoadOptions loadOptions)
        //{
        //    var categories = _context.Categories.Select(i => new
        //    {
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
