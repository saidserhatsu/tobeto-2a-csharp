
using DataAccess.Abstract;

namespace Business.BusinessRules
{
    public class ModelBusinessRules
    {
        private readonly IModelDal _modelDal;

        public ModelBusinessRules(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }

        public void CheckIfModelNameExists(string modelName)
        {
            // Model isminin en az 2 karakter olup olmadığını kontrol et
            if (modelName.Length < 2)
            {
                throw new Exception("Model name must be at least 2 characters.");
            }

            // Model isminin veritabanında zaten var olup olmadığını kontrol et
            bool isExists = _modelDal.GetList().Any(m => m.Name == modelName);
            if (isExists)
            {
                throw new Exception("Model already exists.");
            }
        }

        public void CheckIfDailyPriceIsValid(decimal dailyPrice)
        {
            // DailyPrice'ın 0'dan büyük olup olmadığını kontrol et
            if (dailyPrice <= 0)
            {
                throw new Exception("Daily price must be greater than 0.");
            }
        }
    }
}


/*using DataAccess.Abstract;

namespace Business.BusinessRules
{
    public class ModelBusinessRules
    {
        private readonly IModelDal _modelDal;

        public ModelBusinessRules(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }

        public void CheckIfModelNameExists(string modelName)
        {
            bool isExists = _modelDal.GetList().Any(m => m.Name == modelName);
            if (isExists)
            {
                throw new Exception("Model already exists.");
            }
        }
    }
}
*/