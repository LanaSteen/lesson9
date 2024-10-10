using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abs_Interface.Intefaces;

namespace Abs_Interface.Models
{
    public class Truck : CAR, IFuelTypeGas
    {
        public override void Drive()
        {
            Console.WriteLine("i can drive");
        }

       public void UseGas()
        {
            Console.WriteLine("i use gass");
        }

        public void LoadCargo()
        {
            Console.WriteLine("i can load cargo");
        }


    }
}
