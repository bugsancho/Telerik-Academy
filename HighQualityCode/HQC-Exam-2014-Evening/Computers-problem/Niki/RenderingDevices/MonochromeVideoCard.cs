namespace ComputersSystem.RenderingDevices
{
    using System;

    public class MonochromeVideoCard : VideoCard
    {
        private const ConsoleColor MonochromeCardColor = ConsoleColor.Gray;

        protected override ConsoleColor Color
        {
            get
            {
                return MonochromeVideoCard.MonochromeCardColor;
            }
        }
    }
}