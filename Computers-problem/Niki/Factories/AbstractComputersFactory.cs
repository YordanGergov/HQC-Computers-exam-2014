using Computers.UI.Console.Computers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.UI.Console
{

    public abstract class AbstractComputersFactory
    {
        public abstract PC CreatePc();
        
        public abstract Server CreateServer();

        public abstract Laptop CreateLaptop();
    }
}
