using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.UI.Console.Computers
{
    public class HpFactory : AbstractComputersFactory
    {
        public override PC CreatePc()
        {
            throw new NotImplementedException();
        }

        public override Server CreateServer()
        {
            throw new NotImplementedException();
        }

        public override Laptop CreateLaptop()
        {
            throw new NotImplementedException();
        }
    }
}
