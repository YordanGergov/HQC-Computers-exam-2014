namespace Computers.UI.Console
{

    using System.Collections.Generic;
    using Components;

    public class Computer
    {
        private readonly LaptopBatteryReal battery;

        internal Computer(ComputerType type, Cpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives, VideoCard videoCard,
            LaptopBatteryReal battery)
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

        private VideoCard VideoCard { get; set; }

        private Cpu Cpu { get; set; }

        private Ram Ram { get; set; }
    }

}