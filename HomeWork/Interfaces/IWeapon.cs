﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Interfaces
{
    public interface IWeapon
    {
        string Name { get; }
        decimal Price { get; }
        void DisplayInfo();
    }
}
