using Microsoft.AspNetCore.Mvc;
using HongBaoApi.Models;
using HongBaoApi.Data;
using Microsoft.EntityFrameworkCore;

namespace HongBaoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HongBaoController : ControllerBase
    {
        private readonly HongBaoContext _context;

        public HongBaoController(HongBaoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] HongBao hongbao)
        {
            hongbao.Code = Guid.NewGuid().ToString(); // Overwrite just in case
            _context.HongBaos.Add(hongbao);
            await _context.SaveChangesAsync();

            return Ok(new { url = $"https://yourfrontend.com/open/{hongbao.Code}" });
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> GetByCode(string code)
        {
            var hongbao = await _context.HongBaos.FirstOrDefaultAsync(h => h.Code == code);
            if (hongbao == null) return NotFound();
            return Ok(hongbao);
        }
    }
}
