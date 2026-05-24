using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OgrenciSistemi.Models;
using System.Collections.Generic;
using System.Linq;

namespace OgrenciSistemi.Pages
{
    public class OgrenciDetayModel : PageModel
    {
        public Ogrenci Ogrenci { get; set; }

        public void OnGet(int id)
        {
            var liste = new List<Ogrenci>
            {
                new Ogrenci{ OkulNo=1, Ad="Ali", Soyad="Yılmaz", Alan="Sayısal"},
                new Ogrenci{ OkulNo=2, Ad="Ayşe", Soyad="Kaya", Alan="EA"},
                new Ogrenci{ OkulNo=3, Ad="Mehmet", Soyad="Demir", Alan="Sözel"}
            };

            Ogrenci = liste.FirstOrDefault(x => x.OkulNo == id);
        }
    }
}