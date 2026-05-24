using OgrenciSistemi.Models;

namespace OgrenciSistemi.Services
{
    public class OgrenciService
    {
        private readonly List<Ogrenci> _ogrenciler = new()
        {
            new Ogrenci { Id = 1, Ad = "Ali", Soyad = "Yılmaz", Alan = "Sayısal" },
            new Ogrenci { Id = 2, Ad = "Ayşe", Soyad = "Kaya", Alan = "EA" },
            new Ogrenci { Id = 3, Ad = "Mehmet", Soyad = "Demir", Alan = "Sözel" }
        };

        public List<Ogrenci> Liste() => _ogrenciler;

        public Ogrenci? Getir(int id)
        {
            return _ogrenciler.FirstOrDefault(x => x.Id == id);
        }
    }
}