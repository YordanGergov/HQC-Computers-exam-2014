using Computers.UI.Console.Computers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.UI.Console
{
    public class ComputerDelivery
    {
        private readonly AbstractComputersFactory factory;

        public ComputerDelivery(AbstractComputersFactory factory)
        {
            this.factory = factory; 
        } 
        public PC CreatePc()
        {
            return this.factory.CreatePc();
        }

        public Server CreateServer()
        {
            return this.factory.CreateServer();
        }

        public Laptop CreateLaptop()
        {
            return this.factory.CreateLaptop();
        }

    }
}
