using Computers.UI.Console.Computers;

namespace Computers.UI.Console
{


    using Computers.UI.Console.Components;
    using System;
    using System.Collections.Generic;
    //using Computers.UI.Console.Computers;
    //using Computers.UI.Console.Components;
   
    public abstract class AbstractComputer
    {
        private readonly LaptopBattery battery;
       // private readonly Computers.UI.Console.Components.VideoCard videoCard;

        internal AbstractComputer(ComputerType type, Cpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives,
            HardDrive videoCard, LaptopBattery battery)
        {
            Cpu = cpu;
            Ram = ram;
            HardDrives = hardDrives;
            VideoCard = videoCard;
            if (type !=
                ComputerType.LAPTOP
                && type
                !=
                ComputerType.PC)
            {
                VideoCard.IsMonochrome = true;
            }
            this.battery = battery;
        }

        private IEnumerable<HardDrive> HardDrives { get; set; }

        //private VideoCard VideoCard { get; set; }

        private Cpu Cpu { get; set; }

        private Ram Ram { get; set; }

        internal void ChargeBattery(int percentage)
        {
            battery.Charge(percentage);

            VideoCard.Draw(string.Format("Battery status: {0}", battery.CurrentChargePercentage));
        }

        public void Play(int guessNumber)
        {
            Cpu.Rand(1, 10);
            var number = Ram.LoadValue();
            if (number + 1 != guessNumber + 1)
            {
                VideoCard.Draw(string.Format("You didn't guess the number {0}.", number));
            }
            else
            {
                VideoCard.Draw("You win!");
            }
        }

        internal void Process(int data)
        {
            Ram.SaveValue(data);
            // TODO: Fix it
            Cpu.SquareNumber();
        }
    }
}
