using Computers.UI.Console.Components;
using System;

namespace Computers.UI.Console
{
    internal class Cpu
    {
        private readonly byte numberOfBits;

        private readonly Ram ram;

        private readonly VideoCard videoCard;

        private static readonly Random Random = new Random();

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
            if (numberOfBits == 32)
            {
                this.SquareNumber32();
            }
            if (numberOfBits == 64)
            {
                this.SquareNumber64();
            }
        }

        private void SquareNumber32()
        {
            var data = ram.LoadValue();
            if (data > 500)
            {
                videoCard.Draw("Number too high.");
                return;
            }

            SquareNumberCalculation(data);
        }

        private void SquareNumber64()
        {
            var data = ram.LoadValue();
            if (data > 1000)
            {
                videoCard.Draw("Number too high.");
                return;
            }

            SquareNumberCalculation(data);
        }

        public void SquareNumberCalculation(int data)
        {
            if (data < 0)
            {
                videoCard.Draw("Number too low.");
            }
            else
            {
                int result = (int)Math.Pow(data, 2);             
                videoCard.Draw(string.Format("Square of {0} is {1}.", data, result));
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
            ram.SaveValue(randomNumber);
        }
    }

   
}