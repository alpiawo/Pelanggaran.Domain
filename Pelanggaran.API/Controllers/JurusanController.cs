// Controllers
using Microsoft.AspNetCore.Mvc;
using Pelanggaran.Application;
using Pelanggaran.Domain;

namespace Pelanggaran.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JurusanController : ControllerBase
    {
        private readonly IJurusanService _jurusanService;

        public JurusanController(IJurusanService jurusanService)
        {
            _jurusanService = jurusanService;
        }

        [HttpGet]
        public ActionResult<List<Jurusan>> GetAll()
        {
            var jurusan = _jurusanService.GetAllJurusan();
            return Ok(jurusan);
        }

        [HttpGet("{id}")]
        public ActionResult<Jurusan> GetById(int id)
        {
            var jurusan = _jurusanService.GetJurusanById(id);
            if (jurusan == null) return NotFound();
            return Ok(jurusan);
        }

        [HttpPost]
        public ActionResult Create(Jurusan jurusan)
        {
            var created = _jurusanService.CreateJurusan(jurusan);
            return Ok(created);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, Jurusan jurusan)
        {
            var updated = _jurusanService.UpdateJurusan(id, jurusan);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existing = _jurusanService.GetJurusanById(id);
            if (existing == null) return NotFound();
            _jurusanService.DeleteJurusan(id);
            return Ok("Jurusan berhasil dihapus.");
        }
    }
}
