using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoParkAnimalManagementSystem_EAMS_.Mammals.Species
{

    /// This represents a dog with characteristics.

    public class Dog : Mammal
    {
        public Dog() : base()
        {
        }

        public Dog(int numOfTeeth, double tailLength) : base(numOfTeeth, tailLength)
        {
        }

        public string Breed { get; set; } = "Unknown";

        public bool IsTrained { get; set; } = false;

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                   $"Breed: {Breed}\n" +
                   $"Is Trained: {IsTrained}";
        }
    }
}
