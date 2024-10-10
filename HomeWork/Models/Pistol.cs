using HomeWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    public class Pistol : IWeapon
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Pistol(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Pistol: {Name}, Price: {Price:C}");
        }
    }

   
}
