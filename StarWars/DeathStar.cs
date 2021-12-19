using System;
using System.Collections.Generic;
using System.Text;

namespace StarWars
{
    public class DeathStar : SpaceStation
    {
        public override void FireLaser()
        {
            Console.WriteLine("Pew pew");
        }
    }
}
