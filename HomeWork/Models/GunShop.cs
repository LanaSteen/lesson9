using HomeWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models
{
 
        public class GunShop : IShop
        {
            private List<IWeapon> weapons;
            private decimal shopBalance;

            public GunShop()
            {
                weapons = new List<IWeapon>();
                shopBalance = 0;
            }

            public void AddWeapon(IWeapon weapon)
            {
                weapons.Add(weapon);
                Console.WriteLine($"{weapon.Name} added to the shop.");
            }

            public void RemoveWeapon(string weaponName)
            {
                for (int i = 0; i < weapons.Count; i++)
                {
                    if (weapons[i].Name.Equals(weaponName, StringComparison.OrdinalIgnoreCase))
                    {
                        weapons.RemoveAt(i);
                        Console.WriteLine($"{weaponName} removed from the shop.");
                        return; 
                    }
                }
                Console.WriteLine($"{weaponName} not found in the shop.");
            }

            public void DisplayWeapons()
            {
                Console.WriteLine("Available Weapons:");
                foreach (var weapon in weapons)
                {
                    weapon.DisplayInfo();
                }
            }

            public bool BuyWeapon(string weaponName)
            {
                for (int i = 0; i < weapons.Count; i++)
                {
                    if (weapons[i].Name.Equals(weaponName, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"You bought {weapons[i].Name} for {weapons[i].Price:C}");
                        shopBalance += weapons[i].Price; 
                        weapons.RemoveAt(i); 
                        return true; 
                    }
                }
                Console.WriteLine($"{weaponName} not found in the shop.");
                return false; 
            }

            public void SellWeapon(IWeapon weapon)
            {
                AddWeapon(weapon);
                Console.WriteLine($"You sold {weapon.Name} to the shop.");
            }
        }
    }

