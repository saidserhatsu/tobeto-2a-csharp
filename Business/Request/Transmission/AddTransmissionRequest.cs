namespace Business.Request.Transmission
{
    public class AddTransmissionRequest
    {   // ekleme yap
        public string Name { get; set; }
        public AddTransmissionRequest(string name)
        {
            Name = name;
        }
    }
}
