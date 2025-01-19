using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pelanggaran.Application;
using Pelanggaran.Domain;

namespace Pelanggaran.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeraturanController : ControllerBase
    {
        private readonly IPeraturanService _peraturanService;

        public PeraturanController(IPeraturanService peraturanService)
        {
            _peraturanService = peraturanService;
        }

        [HttpGet]
        public ActionResult<List<Peraturan>> GetAll()
        {
            var peraturan = _peraturanService.GetAllPeraturan();
            return Ok(peraturan);
        }

        [HttpGet("{id}")]
        public ActionResult<Peraturan> GetById(int id)
        {
            var peraturan = _peraturanService.GetPeraturanById(id);
            if (peraturan == null) return NotFound();
            return Ok(peraturan);
        }

        [HttpPost]
        public ActionResult Create(Peraturan peraturan)
        {
            var created = _peraturanService.CreatePeraturan(peraturan);
            return Ok(created);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, Peraturan peraturan)
        {
            var updated = _peraturanService.UpdatePeraturan(id, peraturan);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existing = _peraturanService.GetPeraturanById(id);
            if (existing == null) return NotFound();
            _peraturanService.DeletePeraturan(id);
            return Ok("Peraturan berhasil dihapus.");
        }
    }
}
