using Application.Services.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandRepository _brandRepository;

        public BrandsController(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        [HttpGet("get-brands")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _brandRepository.GetListAsync(enableTracking:false);
            return Ok(result);
        }
    }
}
