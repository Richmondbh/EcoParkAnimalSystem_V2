using EcoParkAnimalManagementSystem_EAMS_.AnimalGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoParkAnimalManagementSystem_EAMS_.Mammals
{
    public class Mammal : Animal
    {
        /// <summary>
        /// Represents a mammal animal with a mammal-specific characteristics.
        /// This also inherits from Animal base class.
        /// </summary>
        private int numberOfTeeth;
        private double tailLength;

        // Default constructor for Mammal for flexibility
        public Mammal() : base()
        {

        }

        // Parameterized constructor for Mammal.
        public Mammal(int numOfTeeth, double tailLength) : base()
        {
            NumberOfTeeth = numOfTeeth;
            TailLength = tailLength;
        }

        public int NumberOfTeeth
        {
            get { return numberOfTeeth; }
            set
            {
                if (value >= 0)
                {
                    numberOfTeeth = value;
                }
            }
        }

        public double TailLength
        {
            get { return tailLength; }
            set
            {
                if (value >= 0)
                {
                    tailLength = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                   $"Number of Teeth: {NumberOfTeeth}\n" +
                   $"Tail Length: {TailLength}";
        }
    }
}
