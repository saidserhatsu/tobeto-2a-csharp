using Business.Abstract;
using Business.Requests.Brand;
using Business.Requests.Fuel;
using Business.Requests.Transmission;
using Business.Responses.Brand;
using Business.Responses.Fuel;
using Business.Responses.Transmission;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelController : ControllerBase
    {
        private readonly IFuelService _fuelService; 

        public FuelController()
        {
            
            _fuelService = FuelServiceRegistration.fuelService;
            
        }        

        [HttpGet] 
        public ICollection<Fuel> GetList()
        {
            IList<Fuel> FuelList = _fuelService.GetList();
            return FuelList; 
        }

       
        [HttpPost] 
        public ActionResult<AddFuelResponse> Add(AddFuelRequest request)
        {
           
            AddFuelResponse response = _fuelService.Add(request);

          
            return CreatedAtAction(nameof(GetList), response); 
        }
    }
}
