using AngularAuthYtAPI.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularAuthYtAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NaturalGasesController : Controller
    {
        private readonly FullstackDbContext _Natural;
        public NaturalGasesController(FullstackDbContext Natural) {
              _Natural = Natural;
        }

        

        [HttpGet]
        public async Task<IActionResult> GetAllNaturalGases()
        {
            var naturals = await _Natural.natural_gases.ToArrayAsync();
            return Ok(naturals);
        }
    }
}
