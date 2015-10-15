namespace Computers.UI.Console.Factories
{

    using System.Collections.Generic;
    using Components;
    using Computers;

    internal class DellFactory : AbstractComputersFactory
    {
        public override PC CreatePc()
        {
            var ram = new Ram(8);
            var videoCard = new VideoCard { IsMonochrome = false };
            var pc = new PC(new Cpu(4, 64, ram, videoCard),
                ram,
                new[] { new HardDrive(1000, false, 0) },
                videoCard);
            return pc;
        }

        public override Server CreateServer()
        {
            var ram1 = new Ram(8 * 8);
            var card = new VideoCard();
            var server = new Server(
                new Cpu(8, 64, ram1, card),
                ram1,
                new List<HardDrive> { new HardDrive(0, true, 2, new List<HardDrive> { new HardDrive(2000, false, 0), new HardDrive(2000, false, 0) }) },
                card);
            return server;
        }

        public override Laptop CreateLaptop()
        {
            var ram = new Ram(8);
            var videoCard = new VideoCard { IsMonochrome = false };
            var laptop = new Laptop(
             new Cpu(4, 32, ram, videoCard),
             ram,
             new[] { new HardDrive(1000, false, 0) },
             videoCard,
             new LaptopBatteryReal());
            return laptop;
        }
    }

}