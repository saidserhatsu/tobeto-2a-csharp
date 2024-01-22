using Core.Entities;
using Microsoft.VisualBasic.FileIO;

namespace Entities.Concrete
{
    public class Model : Entity<int>
    {
        public int BrandId { get; set; }
        public int FuelId { get; set; }//up1
        public int TransmissionId { get; set; }//up2
        public string Name { get; set; }
        public decimal DailyPrice { get; set; }//up3
        public short Year { get; set; }
        public Model()
        {

        }
        public Model(string name)
        {
            Name = name;
        }
        /*şunu yap yine
          public int BrandId { get; set; }
         public int FuelId { get; set; }//up1
         public int TransmissionId { get; set; }//up2
         public string Name { get; set; }
         public decimal DailyPrice { get; set; }//up3
         public short Year { get; set; }

         public Brand? Brand { get; set; } = null;
         public Fuel? Fuel { get; set; } = null;//up4
         public Transmission? Transmission { get; set; } = null;//up5
        */
    }
}
