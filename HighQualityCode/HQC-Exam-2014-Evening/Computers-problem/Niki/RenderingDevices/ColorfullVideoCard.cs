namespace ComputersSystem.RenderingDevices
{
    using System;

    public class ColorfullVideoCard : VideoCard
    {
        private const ConsoleColor MonochromeCardColor = ConsoleColor.Green;

        protected override ConsoleColor Color
        {
            get
            {
                return ColorfullVideoCard.MonochromeCardColor;
            }
        }
    }
}