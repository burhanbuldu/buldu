using Microsoft.AspNetCore.Mvc;
using OgrenciSistemi.Services;

namespace OgrenciSistemi.Controllers
{
    [ApiController]
    [Route("api/ogrenci")]
    public class OgrenciController : ControllerBase
    {
        private readonly OgrenciService _service;

        public OgrenciController(OgrenciService service)
        {
            _service = service;
        }

        [HttpGet("liste")]
        public IActionResult Liste()
        {
            return Ok(_service.Liste());
        }

        [HttpGet("detay/{id}")]
        public IActionResult Detay(int id)
        {
            var ogrenci = _service.Getir(id);

            if (ogrenci == null)
                return NotFound(new { mesaj = "Öğrenci bulunamadı" });

            return Ok(ogrenci);
        }
    }
}