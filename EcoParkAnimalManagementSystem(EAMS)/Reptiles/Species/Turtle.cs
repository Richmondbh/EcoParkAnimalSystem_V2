using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoParkAnimalManagementSystem_EAMS_.Reptiles.Species
{
   
    // This represents a turtle with turtle-specific characteristics.
    public class Turtle : Reptile
    {
        private double shellWidth;

        public Turtle() : base()
        {
        }

        public Turtle(double bodyLength, bool livesInWater, int aggressivenessLevel)
            : base(bodyLength, livesInWater, aggressivenessLevel)
        {
        }

        public string ShellHardness { get; set; } = "Unknown";

        public double ShellWidth
        {
            get { return shellWidth; }
            set
            {
                if (value >= 0)
                {
                    shellWidth = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                   $"Shell Hardness: {ShellHardness}\n" +
                   $"Shell Width: {ShellWidth}";
        }
    }
}
