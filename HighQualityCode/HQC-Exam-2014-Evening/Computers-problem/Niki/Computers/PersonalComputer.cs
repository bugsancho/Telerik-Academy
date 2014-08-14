namespace ComputersSystem.Computers
{
    using Motherboards;
    using ProccessingUnit;
    using StorageDevices;

    public class PersonalComputer : Computer, IPersonalComputer
    {
        // TODO Add more games
        private const int GameLowerBound = 1;
        private const int GameUpperBound = 10;
        private const string GameWonMessage = "You win!";
        private const string GameLostMessageTemplate = "You didn’t guess the number {0}.";

        public PersonalComputer(ICpu cpu, IMotherboard motherboard, IHardDrive drive) : base(cpu, motherboard, drive)
        {
        }

        public void Play(int guessNumber)
        {
            this.Cpu.SaveRandomNumberToRam(PersonalComputer.GameLowerBound, PersonalComputer.GameUpperBound);
            int randomNumber = this.Motherboard.LoadRamValue();
            if (guessNumber == randomNumber)
            {
                this.Motherboard.DrawOnVideoCard(GameWonMessage);
            }
            else
            {
                this.Motherboard.DrawOnVideoCard(string.Format(PersonalComputer.GameLostMessageTemplate, randomNumber));
            }
        }
    }
}