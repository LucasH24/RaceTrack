using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Moped : RaceCar
    {
        public Moped()
        {
            Name = "Moped";
            TopSpeed = 45;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} quietly starts");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} breaks too fast causing Morton to fall over the front!");
            base.Brake();
        }

    }
}
