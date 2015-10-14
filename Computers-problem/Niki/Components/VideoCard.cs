namespace Computers.UI.Console.Components
{
    using System;

    public class VideoCard
    {
        private bool isMonochrome;

        public bool IsMonochrome { get; set; }

        public void Draw(string a)
        {
            if (this.IsMonochrome)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(a);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(a);
                Console.ResetColor();
            }
        }
    }
}
