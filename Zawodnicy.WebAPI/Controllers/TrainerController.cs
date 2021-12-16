using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Zawodnicy.Infrastructure.Commands;
using Zawodnicy.Infrastructure.Services;

namespace Zawodnicy.WebAPI.Controllers
{
    [Microsoft.AspNetCore.Components.Route("[Controller]")]
    public class TrainerController : Controller
    {
        private readonly ITrainerService _trainerService;

        public TrainerController(ITrainerService trainerService)
        {
            _trainerService = trainerService;
        }

        [HttpGet]
        public async Task<IActionResult> BrowseAll()
        {
            var t = await _trainerService.getAll();
            return Json(t);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var t = await _trainerService.get(id);
            return Json(t);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateTrainer ct)
        {
            await _trainerService.create(ct);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(long id)
        {
            await _trainerService.delete(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit([FromBody] UpdateTrainer ut, long id)
        {
            await _trainerService.update(ut, id);
            return Ok();
        }
        
        
    }
}