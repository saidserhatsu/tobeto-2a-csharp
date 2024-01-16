using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class TransmissionBusinnesRules
    {
        private readonly ITransmissionDal _transmissionDal;
        public TransmissionBusinnesRules(ITransmissionDal transmissionDal)
        {
            _transmissionDal = transmissionDal;
        }
        public void CheckIfFuelNameNotExists(string fuelName)
        {
            bool isExists = _transmissionDal.GetList().Any(b => b.TransmissionName == fuelName);
            if (isExists)
            {
                throw new Exception("Transmission already exists.");
            }
        }

        internal void CheckIfTransmissionNameNotExists(string transmissionName)
        {
            throw new NotImplementedException();
        }
    }
}
