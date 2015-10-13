﻿namespace Computers.UI.Console
{
    class LaptopBattery
    {
        internal int Percentage { get; set; }
        internal void Charge(int p)
        {
            Percentage += p;
            if (Percentage > 100) Percentage = 100;
            if (Percentage < 0) Percentage = 0;
        }
        internal LaptopBattery() { Percentage = 100 / 2; }
    }
}
