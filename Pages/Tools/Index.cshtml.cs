using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages.Tools;

public class IndexModel : PageModel
{
    public IActionResult OnGet()
    {
        return Page();
    }
} 