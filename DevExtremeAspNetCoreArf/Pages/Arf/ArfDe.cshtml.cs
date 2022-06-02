using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DevExtremeAspNetCoreArf.Pages.Arf
{
    public class ArfDeModel : PageModel
    {
        public IActionResult OnGet()
        {

            // �������� �� null
            var obj = new ArfDeModel();
            if (obj == null)
                return RedirectToAction("/Error");
            return Page();
        }
    }
}
