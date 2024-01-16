using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Fuel
{
    public class AddFuelRequest
    {
        public string FuelName { get; set; }

        public AddFuelRequest(string name)
        {
            FuelName = name;
        }
    }
}
