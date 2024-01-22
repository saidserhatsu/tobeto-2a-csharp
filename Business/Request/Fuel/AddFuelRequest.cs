namespace Business.Request.Fuel
{
    public class AddFuelRequest
    {
        // ekleme yap
        public string Name { get; set; }
        public AddFuelRequest(string name)
        {
            Name = name;
        }
    }
}
