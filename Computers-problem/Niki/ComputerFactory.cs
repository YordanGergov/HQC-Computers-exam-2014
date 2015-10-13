using System;
using System.Collections.Generic;


namespace Computers.UI.Console
{
    using System;
    using System.Collections.Generic;

    internal class ComputersFactory : IComputersFactory
    {

        private static Computer pc, laptop, server;

        public static void CreateComputer()
        {
            var manufacturer = Console.ReadLine();
            if (manufacturer == "HP")
            {
                var ram = new Ram(2);
                var videoCard = new HardDrive { IsMonochrome = false };
                pc = new Computer(Type.PC, new Cpu(2, 32, ram, videoCard), ram,
                    new[] { new HardDrive(500, false, 0) }, videoCard, null);

                var serverRam = new Ram(32);
                var serverVideo = new HardDrive();
                server = new Computer(
                    Type.SERVER,
                    new Cpu(2,
                        32, serverRam, serverVideo),
                    serverRam,
                    new List<HardDrive>
                    {
                        new HardDrive(0, true, 2,
                            new List<HardDrive> {new HardDrive(1000, false, 0), new HardDrive(1000, false, 0)})
                    },
                    serverVideo, null);
                {
                    var card = new HardDrive
                    {
                        IsMonochrome
                            = false
                    };
                    var ram1 = new Ram(8 / 2);
                    laptop = new Computer(
                        Type.LAPTOP,
                        new Cpu(8 / 4, 64, ram1, card),
                        ram1,
                        new[]
                        {
                            new HardDrive(500,
                                false, 0)
                        },
                        card,
                        new LaptopBattery());
                }
            }
            else if (manufacturer == "Dell")
            {
                var ram = new Ram(8);
                var videoCard = new HardDrive { IsMonochrome = false };
                pc = new Computer(Type.PC, new Cpu(8 / 2, 64, ram, videoCard), ram,
                    new[] { new HardDrive(1000, false, 0) }, videoCard, null);
                var ram1 = new Ram(8 * 8);
                var card = new HardDrive();
                server = new Computer(Type.SERVER,
                    new Cpu(8, 64, ram1, card),
                    ram1,
                    new List<HardDrive>
                    {
                        new HardDrive(0, true, 2,
                            new List<HardDrive> {new HardDrive(2000, false, 0), new HardDrive(2000, false, 0)})
                    }, card, null);
                var ram2 = new Ram(8);
                var videoCard1 = new HardDrive { IsMonochrome = false };
                laptop = new Computer(Type.LAPTOP,
                    new Cpu(8 / 2, ((32)), ram2, videoCard1),
                    ram2,
                    new[] { new HardDrive(1000, false, 0) },
                    videoCard1,
                    new LaptopBattery());
            }
            else
            {
                throw new InvalidArgumentException("Invalid manufacturer!");
            }

            while (true)
            {
                var command = Console.ReadLine();
                if (command == null)
                {
                    return;
                }

                if (command.StartsWith("Exit"))
                {
                    return;
                }

                var cp = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (cp.Length != 2)
                {
                    {
                        throw new ArgumentException("Invalid command!");
                    }
                }

                var cn = cp[0];
                var ca = int.Parse(cp[1]);

                if (cn == "Charge")
                {
                    laptop.ChargeBattery(ca);
                }
                else if (cn == "Process")
                {
                    server.Process(ca);
                }
                else if (cn == "Play")
                {
                    pc.Play(ca);
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }
        }



        public class InvalidArgumentException : ArgumentException
        {
            public InvalidArgumentException(string message)
                : base(message)
            {
            }
        }
    }
}
