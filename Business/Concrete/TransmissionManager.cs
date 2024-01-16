using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Transmission;
using Business.Responses.Fuel;
using Business.Responses.Transmission;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TransmissionManager : ITransmissionService
    {
        private readonly ITransmissionDal _transmissionDal;
        private readonly TransmissionBusinnesRules _transmissionBusinnesRules;
        private readonly IMapper _mapper;

        public TransmissionManager(ITransmissionDal transmissionDal, TransmissionBusinnesRules transmissionBusinnesRules, IMapper mapper)
        {
            _transmissionDal = transmissionDal; 
            _transmissionBusinnesRules = transmissionBusinnesRules;
            _mapper = mapper;
        }


        public AddTransmissionResponse Add(AddTransmissionRequest request)
        {
            _transmissionBusinnesRules.CheckIfTransmissionNameNotExists(request.TransmissionName);

           
            Transmission transmissionToAdd = _mapper.Map<Transmission>(request.TransmissionName); // Mapping

            _transmissionDal.Add(transmissionToAdd);

            AddTransmissionResponse response = _mapper.Map<AddTransmissionResponse>(transmissionToAdd);
            return response;
        }

       
        public IList<Transmission> GetList()
        {
            IList<Transmission> transmissionsList = _transmissionDal.GetList();
            return transmissionsList;
        }
    }
}