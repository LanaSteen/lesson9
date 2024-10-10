using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abs_Interface.Models
{
    public class Bike : CAR
    {
        public override void Drive()
        {
            Console.WriteLine("i can drive");
        }

        public void RingBell()
        {
            Console.WriteLine("i can ring bell");
        }
    }
}
