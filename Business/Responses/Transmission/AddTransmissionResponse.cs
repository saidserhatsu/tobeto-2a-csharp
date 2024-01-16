using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Transmission
{
    public class AddTransmissionResponse
    {
        public int Id { get; set; }
        public string TransmissionName { get; set; }
        public DateTime CreatedAt { get; set; }

        public AddTransmissionResponse(int id, string name, DateTime createdAt)
        {
            Id = id;
            TransmissionName = name;
            CreatedAt = createdAt;
        }
    }
}
