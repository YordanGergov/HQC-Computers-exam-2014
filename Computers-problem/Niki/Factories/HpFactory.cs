﻿namespace Computers.UI.Console.Factories
{

    using System;
    using System.Collections.Generic;
    using Components;
    using Computers;
    

    public class HpFactory : AbstractComputersFactory
    {
        public override PC CreatePc()
        {
            var ram = new Ram(2);
            var videoCard = new VideoCard { IsMonochrome = false };
            var pc = new PC(new Cpu(2, 32, ram, videoCard),
                ram,
                new[] { new HardDrive(500, false, 0) },
                videoCard);
            return pc;
        }

        public override Server CreateServer()
        {
            var ram1 = new Ram(32);
            var card = new VideoCard();
            var server = new Server(
                new Cpu(4, 32, ram1, card),
                ram1,
                new List<HardDrive> { new HardDrive(0, true, 2, new List<HardDrive> { new HardDrive(1000, false, 0), new HardDrive(1000, false, 0) }) },
                card);
            return server;
        }

        public override Laptop CreateLaptop()
        {
            var ram = new Ram(4);
            var videoCard = new VideoCard { IsMonochrome = false };
            var laptop = new Laptop(
             new Cpu(2, 64, ram, videoCard),
             ram,
             new[] { new HardDrive(500, false, 0) },
             videoCard,
             new LaptopBatteryReal());
            return laptop;
        }
    }

}