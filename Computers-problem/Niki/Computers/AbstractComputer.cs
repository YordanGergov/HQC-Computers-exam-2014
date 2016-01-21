namespace Computers.UI.Console.Computers
{
    using System.Collections.Generic;
    using Components;

    public abstract class AbstractComputer
    {
          internal AbstractComputer(Cpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives, VideoCard videoCard)
        {
            this.Cpu = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;
        }

        protected VideoCard VideoCard { get; set; }

        protected IEnumerable<HardDrive> HardDrives { get; set; }

        protected Ram Ram { get; set; }

        protected Cpu Cpu { get; set; }
    }
}