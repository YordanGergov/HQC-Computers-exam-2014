using Computers.UI.Console.Computers;
using Computers.UI.Console.Factories;
using System;
namespace Computers.UI.Console
{
    using System;
    public static class Program
    {
        private static PC pc;
        private static Laptop laptop;
        private static Server server;
        public static void Main()
        {


            string manufacturer = Console.ReadLine();
            if (manufacturer == "HP")
            {
               var manufacturerFactory = new HpFactory();
               pc = manufacturerFactory.CreatePc();
                server = manufacturerFactory.CreateServer();
                laptop = manufacturerFactory.CreateLaptop();
            }
            else if (manufacturer == "Dell")
            {
                var manufacturerFactory = new DellFactory();
                pc = manufacturerFactory.CreatePc();
                server = manufacturerFactory.CreateServer();
                laptop = manufacturerFactory.CreateLaptop();
            }
            else if (manufacturer == "Lenovo")
            {
               var manufacturerFactory = new LenovoFactory();
               pc = manufacturerFactory.CreatePc();
               server = manufacturerFactory.CreateServer();
               laptop = manufacturerFactory.CreateLaptop();
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

                var commandProduce = command.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                if (commandProduce.Length != 2)
                {
                    {
                        throw new ArgumentException("Invalid command!");
                    }
                }

                var comandName = commandProduce[0];
                var ca = int.Parse(commandProduce[1]);

                if (comandName == "Charge")
                {
                    laptop.ChargeBattery(ca);
                }
                else if (comandName == "Process")
                {
                    server.Process(ca);
                }
                else if (comandName == "Play")
                {
                    pc.Play(ca);
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }
        
    }

}
}