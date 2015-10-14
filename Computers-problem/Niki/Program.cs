using Computers.UI.Console.Computers;
namespace Computers.UI.Console
{
    public class ComputerBuilding
    {
          private static void Main()
        {
            var HPcomputers = new HpFactory();
            var Dellcomputers = new DellFactory();
        }
    }
}