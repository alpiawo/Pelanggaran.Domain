using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pelanggaran.Application;
using Pelanggaran.Domain;

namespace Pelanggaran.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuruController : ControllerBase
    {
        private readonly IGuruService _guruService;

        public GuruController(IGuruService guruService)
        {
            _guruService = guruService;
        }

        [HttpGet]
        public ActionResult<List<Guru>> GetAll()
        {
            var guru = _guruService.GetAllGuru();
            return Ok(guru);
        }

        [HttpGet("{id}")]
        public ActionResult<Guru> GetById(int id)
        {
            var guru = _guruService.GetGuruById(id);
            if (guru == null) return NotFound();
            return Ok(guru);
        }

        [HttpPost]
        public ActionResult Create(Guru guru)
        {
            var created = _guruService.CreateGuru(guru);
            return Ok(created);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, Guru guru)
        {
            var updated = _guruService.UpdateGuru(id, guru);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existing = _guruService.GetGuruById(id);
            if (existing == null) return NotFound();
            _guruService.DeleteGuru(id);
            return Ok("Guru berhasil dihapus.");
        }
    }
}
