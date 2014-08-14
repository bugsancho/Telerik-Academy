namespace ComputersSystem.Motherboards
{
    /// <summary>
    /// Interface that represents a motherborad that holds together a RAM memory and a video card.
    /// Provides interfaces for loading and saving numbers in the RAM and a method to display information using the video card.
    /// </summary>
    public interface IMotherboard
    {
        /// <summary>
        /// Load a number from the ram such is available.
        /// </summary>
        /// <returns>An integer, loaded from the RAM of the motherboard</returns>
        int LoadRamValue();

        /// <summary>
        /// Saves a number to the motherboard's RAM
        /// </summary>
        /// <param name="value">The integer to be saved to the RAM.</param>
        void SaveRamValue(int value);

        /// <summary>
        /// Render a message on the motherboard's video card.
        /// </summary>
        /// <param name="data">Message to be rendered to video card</param>
        void DrawOnVideoCard(string data);
    }
}