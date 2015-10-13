using System;

namespace Computers.UI.Console
{
    internal class Cpu
    {
        private readonly byte numberOfBits;

        private readonly Ram ram;

        private readonly HardDrive videoCard;

        private static readonly Random Random = new Random();

        internal Cpu(byte numberOfCores, byte numberOfBits, Ram ram, HardDrive videoCard)
        {
            this.numberOfBits = numberOfBits;
            this.ram = ram;
            NumberOfCores = numberOfCores;
            this.videoCard = videoCard;
        }

        private byte NumberOfCores { get; set; }

        public void SquareNumber()
        {
            if (numberOfBits == 32) SquareNumber32();
            if (numberOfBits == 64) SquareNumber64();
        }

        private void SquareNumber32()
        {
            var data = ram.LoadValue();
            if (data > 500)
            {
                videoCard.Draw("Number too high.");
            }

            SquareNumberCalculation(data);
        }

        private void SquareNumber64()
        {
            var data = ram.LoadValue();
            if (data > 1000)
            {
                videoCard.Draw("Number too high.");
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
                int value = 0;
                for (int i = 0; i < data; i++)
                {
                    value += data;
                }
                videoCard.Draw(string.Format("Square of {0} is {1}.", data, value));
            }
        }

        internal void rand(int a, int b)
        {
            int randomNumber;
            do
            {
                randomNumber = Random.Next(0, 1000);
            } while (!(randomNumber >= a && randomNumber <= b));
            ram.SaveValue(randomNumber);
        }
    }

    internal class ComputerBuildingSystem
    {
       
    }
}