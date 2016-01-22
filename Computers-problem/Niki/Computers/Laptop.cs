namespace Computers.UI.Console.Computers
{

    using System.Collections.Generic;
    using Components;

    public class Laptop : AbstractComputer
    {
        private LaptopBatteryReal laptopBatery;

        public Laptop(Cpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives, VideoCard videoCard, LaptopBatteryReal laptopBatery)
            : base(cpu, ram, hardDrives, videoCard)
        {
            this.laptopBatery = laptopBatery;
        }

        internal void ChargeBattery(int percentage)
        {
            this.laptopBatery.Charge(percentage);

            this.VideoCard.Draw(string.Format("Battery status: {0}", this.laptopBatery.CurrentChargePercentage));
        }
    }
}