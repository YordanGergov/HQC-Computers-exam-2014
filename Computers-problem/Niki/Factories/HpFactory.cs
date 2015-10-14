namespace Computers.UI.Console.Factories
{

    using System;
    using Computers;

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