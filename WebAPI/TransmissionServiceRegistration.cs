using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using Business.Requests.Transmission;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace WebAPI
{
    public class TransmissionServiceRegistration
    {
        public static readonly ITransmissionDal TransmissionDal = new InMemoryTransmissionDal();

        public static readonly TransmissionBusinnesRules TransmissionBusinnesRules = new TransmissionBusinnesRules(TransmissionDal);

        public static IMapper Mapper = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<AddTransmissionRequest, Fuel>();
            cfg.CreateMap<Fuel, AddTransmissionRequest>();
        }).CreateMapper();

        public static readonly ITransmissionService transmissionService = new TransmissionManager(
            TransmissionDal,
            TransmissionBusinnesRules,
            Mapper
        );
    }
}
