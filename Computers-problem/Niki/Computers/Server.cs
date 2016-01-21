namespace Computers.UI.Console.Computers
{

    using System.Collections.Generic;
    using Components;

    public class Server : AbstractComputer
    {
        public Server(Cpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives, VideoCard videoCard) : base(cpu, ram, hardDrives, videoCard)
        {
            this.VideoCard.IsMonochrome = true;
        }

        internal void Process(int data)
        {
            this.Ram.SaveValue(data);
            this.Cpu.SquareNumber();
        }
    }
}