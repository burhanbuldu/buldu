using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IsBasvuruSite.Pages
{
    public class Index1Model : PageModel
    {
        [BindProperty] public string Ad { get; set; }
        [BindProperty] public string Soyad { get; set; }
        [BindProperty] public string Cinsiyet { get; set; }
        [BindProperty] public string Pozisyon { get; set; }
        [BindProperty] public decimal Ucret { get; set; }

        public bool Gonderildi { get; set; }

        public void OnGet()
        {
            Gonderildi = false;
        }

        public void OnPost()
        {
            Gonderildi = true;
        }
    }
}