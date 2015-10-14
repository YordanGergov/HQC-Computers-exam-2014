namespace Computers.UI.Console
{

    using System;
    using Components;

    internal class Cpu
    {
        private static readonly Random Random = new Random();
        private readonly byte numberOfBits;

        private readonly Ram ram;

        private readonly VideoCard videoCard;

        internal Cpu(byte numberOfCores, byte numberOfBits, Ram ram, VideoCard videoCard)
        {
            this.numberOfBits = numberOfBits;
            this.ram = ram;
            this.NumberOfCores = numberOfCores;
            this.videoCard = videoCard;
        }

        private byte NumberOfCores { get; set; }

        public void SquareNumber()
        {
            if (this.numberOfBits == 32)
            {
                this.SquareNumber32();
            }
            if (this.numberOfBits == 64)
            {
                this.SquareNumber64();
            }
        }

        private void SquareNumber32()
        {
            var data = this.ram.LoadValue();
            if (data > 500)
            {
                this.videoCard.Draw("Number too high.");
                return;
            }

            this.SquareNumberCalculation(data);
        }

        private void SquareNumber64()
        {
            var data = this.ram.LoadValue();
            if (data > 1000)
            {
                this.videoCard.Draw("Number too high.");
                return;
            }

            this.SquareNumberCalculation(data);
        }

        public void SquareNumberCalculation(int data)
        {
            if (data < 0)
            {
                this.videoCard.Draw("Number too low.");
            }
            else
            {
                var result = (int) Math.Pow(data, 2);
                this.videoCard.Draw(string.Format("Square of {0} is {1}.", data, result));
            }
        }

        internal void Rand(int a, int b)
        {
            int randomNumber;
            do
            {
                randomNumber = Random.Next(0, 1000);
            }
            while (!(randomNumber >= a && randomNumber <= b));
            this.ram.SaveValue(randomNumber);
        }
    }

}