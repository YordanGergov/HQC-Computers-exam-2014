
namespace Computers.UI.Console
{
    using System;
    using System.Collections.Generic;
   
    internal class Computer
    {
        private readonly LaptopBattery battery;

        internal Computer(Type type, Cpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives,
            HardDrive videoCard, LaptopBattery battery)
        {
            Cpu = cpu;
            Ram = ram;
            HardDrives = hardDrives;
            VideoCard = videoCard;
            if (type !=
                Type.LAPTOP
                && type
                !=
                Type.PC)
            {
                VideoCard.IsMonochrome = true;
            }
            this.battery = battery;
        }

        private IEnumerable<HardDrive> HardDrives { get; set; }

        private HardDrive VideoCard { get; set; }

        private Cpu Cpu { get; set; }

        private Ram Ram { get; set; }

        [Obsolete("")]
        internal void ChargeBattery(int percentage)
        {
            battery.Charge(percentage);

            VideoCard.Draw(string.Format("Battery status: {0}", battery.Percentage));
        }

        public void Play(int guessNumber)
        {
            Cpu.rand(1, 10);
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
