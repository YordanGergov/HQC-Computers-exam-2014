using Computers.UI.Console.Computers;
namespace Computers.UI.Console.Factories
{

    internal class DellFactory : AbstractComputersFactory
    {
        public override PC CreatePc()
        {
            throw new System.NotImplementedException();
        }

        public override Server CreateServer()
        {
            throw new System.NotImplementedException();
        }

        public override Laptop CreateLaptop()
        {
            throw new System.NotImplementedException();
        }
    }

}