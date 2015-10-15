namespace Computers.UI.Console.Factories
{

    using Computers;

    public abstract class AbstractComputersFactory
    {

        public abstract PC CreatePc();

        public abstract Server CreateServer();

        public abstract Laptop CreateLaptop();
    }

}