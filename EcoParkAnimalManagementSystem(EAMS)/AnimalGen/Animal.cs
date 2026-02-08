using EcoParkAnimalManagementSystem_EAMS_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EcoParkAnimalManagementSystem_EAMS_.AnimalGen
{


    // This is the base class representing common properties and the behaviors for all the animals.
    public abstract class Animal: IAnimal

    {
        private static int nextId = 1;

        // Backing fields  for only properties that needs validation
        private double age;
        private double weight;

        // Auto-properties for those with no validation needed
        public int Id { get; private set; }
        public string Name { get; set; } = "Unknown";
        public GenderType Gender { get; set; } = GenderType.Unknown;
        public string ImagePath { get; set; } = string.Empty;


        public Animal()
        {
            Id = nextId++;
        }

        public double Age
        {
            get { return age; }
            set
            {
                //Program must not crash
                if (value >= 0)
                {
                    age = value;
                }
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                // Program must not crash
                if (value >= 0)
                {
                    weight = value;
                }
            }
        }

        public override string ToString()
        {
            return $"ID: {Id}\n" +
                   $"Name: {Name}\n" +
                   $"Age: {Age}\n" +
                   $"Weight: {Weight}\n" +
                   $"Gender: {Gender}";
        }

    }
}
