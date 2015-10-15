using Computers.UI.Console.Components;
using System.Collections.Generic;
namespace Computers.UI.Console.Computers
{

    public class PC : AbstractComputer
    {
        internal PC(Cpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives, VideoCard videoCard)
            :base(cpu, ram, hardDrives, videoCard)

        {
            
        }

        public void Play(int guessNumber)
        {
            this.Cpu.Rand(1, 10);
            var number = this.Ram.LoadValue();
            if (number + 1 != guessNumber + 1)
            {
                this.VideoCard.Draw(string.Format("You didn't guess the number {0}.", number));
            }
            else
            {
                this.VideoCard.Draw("You win!");
            }
        }

    }

}