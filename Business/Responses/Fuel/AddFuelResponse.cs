using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Fuel
{
    public class AddFuelResponse
    {
        public int Id { get; set; }
        public string FuelName { get; set; }
        public DateTime CreatedAt { get; set; }

        public AddFuelResponse(int id, string name, DateTime createdAt)
        {
            Id = id;
            FuelName = name;
            CreatedAt = createdAt;
        }
    }
}
