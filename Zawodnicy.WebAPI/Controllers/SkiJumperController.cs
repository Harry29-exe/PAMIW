using System;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Zawodnicy.Infrastructure.Commands;
using Zawodnicy.Infrastructure.Services;

namespace Zawodnicy.WebAPI.Controllers
{
    [Route("[Controller]")]
    public class SkiJumperController : Controller
    {
        private readonly ISkiJumperService _skiJumperService;

        public SkiJumperController(ISkiJumperService skiJumperService)
        {
            this._skiJumperService = skiJumperService;
        }

        [HttpGet]
        public async Task<IActionResult> BrowseAll()
        {
            var z = await _skiJumperService.BrowseAll();

            return Json(z);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSkiJumper(int id)
        {
            var j = _skiJumperService.GetSkiJumper(id);
            return Json(j);
        }

        [HttpGet("filter")]
        public async Task<IActionResult>  GetSkiJumpers(string country, string name)
        {
            var j = _skiJumperService.GetSkiJumpers(country, name);
            return Json(j);
        }

        [HttpPost]
        public async Task<IActionResult> AddSkiJumper([FromBody] CreateSkiJumper request)
        {
            await _skiJumperService.AddSkiJumper(request);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditSkiJumper([FromBody] UpdateSkiJumper request, int id)
        {
            _skiJumperService.EditSkiJumper(request, id);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJkiJumper(int id)
        {
            _skiJumperService.DeleteJkiJumper(id);
            return Ok();
        }
    }
}