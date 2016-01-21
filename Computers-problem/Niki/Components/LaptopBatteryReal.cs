namespace Computers.UI.Console
{
    public class LaptopBatteryReal
    {
        private const int InitialPercentage = 50;

        public LaptopBatteryReal()
        {
            this.CurrentChargePercentage = InitialPercentage;
        }

        public int CurrentChargePercentage { get; set; }

        public void Charge(int chargePercentage)
        {
            this.CurrentChargePercentage += chargePercentage;
            if (this.CurrentChargePercentage > 100)
            {
                this.CurrentChargePercentage = 100;
            }

            if (this.CurrentChargePercentage < 0)
            {
                this.CurrentChargePercentage = 0;
            }
        }
    }
}