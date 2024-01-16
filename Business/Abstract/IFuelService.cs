using Business.Requests.Brand;
using Business.Requests.Fuel;
using Business.Requests.Transmission;
using Business.Responses.Brand;
using Business.Responses.Fuel;
using Business.Responses.Transmission;
using Entities.Concrete;


namespace Business.Abstract
{
    public interface IFuelService
    {
          public AddFuelResponse Add(AddFuelRequest request);
          public IList<Fuel> GetList();


      


    }
}
