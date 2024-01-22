using Business;
using Business.Abstract;
using Business.Request.Brand;
using Business.Responses.Brand;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;//Field
        public BrandsController(IBrandService brandService)
        {
            // Her HTTP Request için yeni bir Controller nesnesi oluşturulur.
            _brandService = brandService;
        }

        [HttpGet]
        public GetBrandListResponse GetList([FromQuery] GetBrandListRequest request)// Referans tipleri varsayılan olarak request body'den alır.
        {
            GetBrandListResponse response = _brandService.GetList(request);
            return response; //JSON
        }

        //[HttpPost("/add")]// http://localhost:5031/api/brands/add
        [HttpPost] //POST http://localhost:5031/api/brands
        public ActionResult<AddBrandResponse> Add(AddBrandRequest request)
        {
           
            {

                AddBrandResponse response = _brandService.Add(request);
                //return response; // 200 OK

                return CreatedAtAction(nameof(GetList), response); // 201 Created 
            }
         
        }
    }
}