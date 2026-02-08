using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoParkAnimalManagementSystem_EAMS_.Reptiles.Species
{
   
    // Represents a snake with specific characteristics.

    public class Snake : Reptile
    {
        private double speed;

        public Snake() : base()
        {
        }

        public Snake(double bodyLength, bool livesInWater, int aggressivenessLevel)
           : base(bodyLength, livesInWater, aggressivenessLevel)
        {

        }

        public bool IsVenomous { get; set; } = false;

        public double Speed
        {
            get { return speed; }
            set
            {
                if (value >= 0)
                {
                    speed = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                   $"Is Venomous: {IsVenomous}\n" +
                   $"Speed: {Speed}";
        }
    }
}
