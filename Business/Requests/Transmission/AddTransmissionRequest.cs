using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Transmission
{
    public class AddTransmissionRequest
    {
        public string TransmissionName { get; set; }

        public AddTransmissionRequest(string name)
        {
            TransmissionName = name;
        }
    }
}
