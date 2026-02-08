using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoParkAnimalManagementSystem_EAMS_.Mammals.Species
{

    // This represents a cat with characteristics.
  
    public class Cat: Mammal
    {
        public Cat() : base()
        {
        }

        public Cat(int numOfTeeth, double tailLength) : base(numOfTeeth, tailLength)
        {
        }


        public string FurColor { get; set; } = "Unknown";

        public bool IsPurebred { get; set; } = false;

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                   $"Fur Color: {FurColor}\n" +
                   $"Is Purebred: {IsPurebred}";
        }


    }

}
