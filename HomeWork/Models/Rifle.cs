using HomeWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    public class Rifle : IWeapon
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Rifle(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Rifle: {Name}, Price: {Price:C}");
        }
    }
}
