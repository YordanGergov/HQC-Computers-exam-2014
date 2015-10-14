using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.UI.Console.Components
{
    public class VideoCard
    {
        private bool isMonochrome;

        public VideoCard(bool isMonochrome)
        {
            this.isMonochrome = IsMonochrome;
        }

        public bool IsMonochrome { get; set; }

        public void Draw(string a)
        {
            if (IsMonochrome)
            {
                System.Console.ForegroundColor = ConsoleColor.Gray;
                System.Console.WriteLine(a);
                System.Console.ResetColor();
            }

            else
            {
                System.Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine(a);
                System.Console.ResetColor();
            }

        }
    }
}
