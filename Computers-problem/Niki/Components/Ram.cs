namespace Computers.UI.Console
{
    class Ram
    {
        int value;

        internal Ram(int a)
        {
            Amount = a;
        }
        int Amount { get; set; }

        public void SaveValue(int newValue)
        {
            value = newValue;

        }

        public int LoadValue()
        {
            return value;

        }
    }
}