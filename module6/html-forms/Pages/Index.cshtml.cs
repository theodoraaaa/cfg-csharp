using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace html_forms.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    string Username {get; set;}
    
    [BindProperty]
    bool Newsletter {get; set;}

    bool Submitted {get; set;}

    void OnGet()
    {
        Submitted = true;
    }   

}