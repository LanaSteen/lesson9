using HomeWork.Interfaces;
using HomeWork.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        IShop gunShop = new GunShop();

      
        gunShop.AddWeapon(new Pistol("Pistol1", 200));
        gunShop.AddWeapon(new Rifle("Rifle1", 1000));

     
        gunShop.DisplayWeapons();

      
        gunShop.BuyWeapon("Rifle1");
       
        gunShop.DisplayWeapons();

        gunShop.SellWeapon(new Pistol("Pistol2", 600));

        gunShop.DisplayWeapons();
    }
}