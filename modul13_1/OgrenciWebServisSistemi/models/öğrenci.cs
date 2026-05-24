namespace OgrenciSistemi.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; } = string.Empty;
        public string Soyad { get; set; } = string.Empty;
        public string Alan { get; set; } = string.Empty;

        public string TamAd => $"{Ad} {Soyad}";
    }
}