using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ui.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet() {}

        public IndexModel()
        {
            Prop = "i have no idea what is going on";
        }

        public string Prop { get; set; }
    }
}