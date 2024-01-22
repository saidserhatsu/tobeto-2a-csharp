﻿using DataAccess.Abstract;

namespace Business.BusinessRules
{
    public class TransmissionBusinessRules
    {
        private readonly ITransmissionDal _transmissionDal;
        public TransmissionBusinessRules(ITransmissionDal transmissionDal)
        {
            _transmissionDal = transmissionDal;
        }
        public void CheckIfNameTransmissionNameExists(string tName)
        {
            bool isExists = _transmissionDal.GetList().Any(x => x.Name == tName);
            if (isExists)
            {
                throw new Exception("Transmission already exists.");
            }
        }
    }
}
