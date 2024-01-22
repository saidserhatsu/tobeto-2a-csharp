namespace Business.Request.Model
{
    public class AddModelRequest
    {
        // ekleme yap
        public string Name { get; set; }
        public AddModelRequest(string name)
        {
            Name = name;
        }

    }
}
