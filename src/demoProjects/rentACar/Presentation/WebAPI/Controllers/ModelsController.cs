using Application.Features.Models.Models;
using Application.Features.Models.Queries.GetListModel;
using Core.Application.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : CommonController
    {


        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListModelQuery getListModelQuery = new();
            getListModelQuery.PageRequest = pageRequest;

            ModelListModel result = await Mediator.Send(getListModelQuery);
            return Created("", result);
        }
    }
}
