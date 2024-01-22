using Business;
using Business.Abstract;
using Business.Request.Model;
using Business.Responses.Model;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private readonly IModelService _modelService;

        public ModelsController(IModelService modelService)
        {
            _modelService = modelService;
        }

        [HttpGet]
        public ActionResult<GetModelListResponse> GetList([FromQuery] GetModelListRequest request)
        {
            GetModelListResponse response = _modelService.GetList(request);
            return response;
        }
        [HttpPost]


        public ActionResult<AddModelResponse> Add(AddModelRequest request)
        {
            AddModelResponse response = _modelService.Add(request);
            //200 OK
            return CreatedAtAction(nameof(GetList), response); // 201 Created 
        }

    }
}
