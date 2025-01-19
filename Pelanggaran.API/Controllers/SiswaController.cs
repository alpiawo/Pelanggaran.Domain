using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pelanggaran.Application;
using Pelanggaran.Domain;

namespace Pelanggaran.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiswaController : ControllerBase
    {
        private readonly ISiswaService _siswaService;

        public SiswaController(ISiswaService siswaService)
        {
            _siswaService = siswaService;
        }

        [HttpGet]
        public ActionResult<List<Siswa>> GetAll()
        {
            var siswa = _siswaService.GetAllSiswa();
            return Ok(siswa);
        }

        [HttpGet("{id}")]
        public ActionResult<Siswa> GetById(int id)
        {
            var siswa = _siswaService.GetSiswaById(id);
            if (siswa == null) return NotFound();
            return Ok(siswa);
        }

        [HttpPost]
        public ActionResult Create(Siswa siswa)
        {
            var created = _siswaService.CreateSiswa(siswa);
            return Ok(created);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, Siswa siswa)
        {
            var updated = _siswaService.UpdateSiswa(id, siswa);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existing = _siswaService.GetSiswaById(id);
            if (existing == null) return NotFound();
            _siswaService.DeleteSiswa(id);
            return Ok("Siswa berhasil dihapus.");
        }
    }
}
