using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Interfaces
{
    public interface IShop
    {
        void AddWeapon(IWeapon weapon);
        void RemoveWeapon(string weaponName);
        void DisplayWeapons();
        bool BuyWeapon(string weaponName);
        void SellWeapon(IWeapon weapon);
    }
}
