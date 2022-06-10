using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

//https://www.talkingdotnet.com/handle-ajax-requests-in-asp-net-core-razor-pages/
namespace DevExtremeAspNetCoreArf.Pages.Examples
{
    public class AjaxModel : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }

        private List<string> lstString = new List<string>
            {
                "Val 1-",
                "Val 2",
                "Val 3"
            };

        public JsonResult OnGetList()
        {
            
            return new JsonResult(lstString);
        }

        public ActionResult OnPostSend()
        {
            string sPostValue1 = "";
            string sPostValue2 = "";
            string sPostValue3 = "";
            {
                var syncIOFeature = HttpContext.Features.Get<IHttpBodyControlFeature>();
                if (syncIOFeature != null)
                {
                    syncIOFeature.AllowSynchronousIO = true;
                }

                MemoryStream stream = new MemoryStream();
                Request.Body.CopyTo(stream);
                stream.Position = 0;
                using (StreamReader reader = new StreamReader(stream))
                {
                    string requestBody = reader.ReadToEnd();
                    if (requestBody.Length > 0)
                    {
                        var obj = JsonConvert.DeserializeObject<PostData>(requestBody);
                        if (obj != null)
                        {
                            sPostValue1 = obj.Item1;
                            sPostValue2 = obj.Item2;
                            sPostValue3 = obj.Item3;
                        }
                    }
                }
            }
            lstString = new List<string>
            {
                sPostValue1,
                sPostValue2,
                sPostValue3
            };
            return new JsonResult(lstString);
        }

        public class PostData
        {
            public string Item1 { get; set; }
            public string Item2 { get; set; }
            public string Item3 { get; set; }
        }
    }
}
