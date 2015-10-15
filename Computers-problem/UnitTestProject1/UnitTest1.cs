namespace UnitTestProject1
{

    using Computers.UI.Console;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ComputersBuildingSystemTests
    {
        // Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
        }

        // Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup]
        public static void ClassCleanup()
        {
        }

        // Use TestInitialize to run code before running each test
        [TestInitialize]
        public void TestInitialize()
        {
        }

        // Use TestCleanup to run code after each test has run
        [TestCleanup]
        public void TestCleanup()
        {
        }

        [TestMethod]
        public void TestMethod1()
        {
            var laptopBattery = new LaptopBatteryReal();
            laptopBattery.Charge(60);
            Assert.AreEqual(100, laptopBattery.CurrentChargePercentage);
        }
    }
}
