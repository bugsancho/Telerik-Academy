namespace ComputersSystem.RenderingDevices
{
    using System;

    public abstract class VideoCard : IVideoCard
    {
        public VideoCard()
        {
        }

        protected abstract ConsoleColor Color { get; }

        public void Draw(string message)
        {
            Console.ForegroundColor = this.Color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}