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
            throw new NetworkInformationException();
        }

        [HttpGet("filter")]
        public async Task<IActionResult>  GetSkiJumper(string country, string name)
        {
            throw new NetworkInformationException();
        }

        [HttpPost]
        public async Task<IActionResult> AddSkiJumper([FromBody] CreateSkiJumper request)
        {
            throw new NetworkInformationException();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditSkiJumper([FromBody] UpdateSkiJumper request, int id)
        {
            throw new NetworkInformationException();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJkiJumper(int id)
        {
            throw new NotImplementedException();
        }
    }
}