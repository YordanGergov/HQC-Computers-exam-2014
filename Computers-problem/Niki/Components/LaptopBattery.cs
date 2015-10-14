namespace Computers.UI.Console
{
    public class LaptopBattery
    {
        private const int InitialPercentage = 50;
        public LaptopBattery()
        {
            CurrentChargePercentage = InitialPercentage;
        }
        public int CurrentChargePercentage { get; set; }

        public void Charge(int chargePercentage)
        {
            CurrentChargePercentage += chargePercentage;
            if (CurrentChargePercentage > 100)
            {
                CurrentChargePercentage = 100;
            }
            if (CurrentChargePercentage < 0)
            {
                CurrentChargePercentage = 0;
            }
        }
    }
}
