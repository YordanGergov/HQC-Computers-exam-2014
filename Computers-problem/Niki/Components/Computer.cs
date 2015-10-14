namespace Computers.UI.Console
{

    using System;
    using System.Collections.Generic;

    public abstract class Computer
    {
        private readonly LaptopBattery battery;

        internal Computer(ComputerType type, Cpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives, HardDrive videoCard, LaptopBattery battery)
        {
            this.Cpu = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;
            if (type !=
                ComputerType.LAPTOP
                && type
                !=
                ComputerType.PC)
            {
                this.VideoCard.IsMonochrome = true;
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
            this.battery.Charge(percentage);

            this.VideoCard.Draw(string.Format("Battery status: {0}", this.battery.CurrentChargePercentage));
        }

        public void Play(int guessNumber)
        {
            this.Cpu.Rand(1, 10);
            var number = this.Ram.LoadValue();
            if (number + 1 != guessNumber + 1)
            {
                this.VideoCard.Draw(string.Format("You didn't guess the number {0}.", number));
            }
            else
            {
                this.VideoCard.Draw("You win!");
            }
        }

        internal void Process(int data)
        {
            this.Ram.SaveValue(data);
            // TODO: Fix it
            this.Cpu.SquareNumber();
        }
    }

}