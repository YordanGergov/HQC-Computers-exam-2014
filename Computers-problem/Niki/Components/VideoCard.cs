namespace Computers.UI.Console.Components
{

    using System;

    public class VideoCard
    {
        public bool IsMonochrome { get; set; }

        public void Draw(string status)
        {
            if (this.IsMonochrome)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(status);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(status);
                Console.ResetColor();
            }
        }
    }

}