using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pelanggaran.Application;
using Pelanggaran.Domain;

namespace Pelanggaran.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KelasController : ControllerBase
    {
        private readonly IKelasService _kelasService;

        public KelasController(IKelasService kelasService)
        {
            _kelasService = kelasService;
        }

        [HttpGet]
        public ActionResult<List<Kelas>> GetAll()
        {
            var kelas = _kelasService.GetAllKelas();
            return Ok(kelas);
        }

        [HttpGet("{id}")]
        public ActionResult<Kelas> GetById(int id)
        {
            var kelas = _kelasService.GetKelasById(id);
            if (kelas == null) return NotFound();
            return Ok(kelas);
        }

        [HttpPost]
        public ActionResult Create(Kelas kelas)
        {
            var created = _kelasService.CreateKelas(kelas);
            return Ok(created);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, Kelas kelas)
        {
            var updated = _kelasService.UpdateKelas(id, kelas);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existing = _kelasService.GetKelasById(id);
            if (existing == null) return NotFound();
            _kelasService.DeleteKelas(id);
            return Ok("Kelas berhasil dihapus.");
        }
    }
}
