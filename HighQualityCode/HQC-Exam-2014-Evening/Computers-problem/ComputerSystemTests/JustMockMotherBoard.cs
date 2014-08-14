namespace ComputerSystemTests
{
    using ComputersSystem.Motherboards;
    using Telerik.JustMock;

    public class JustMockMotherBoard : IMotherboard
    {
        private readonly IMotherboard board;
        private int savedValue;

        public JustMockMotherBoard()
        {
            this.board = Mock.Create<IMotherboard>();
            Mock.Arrange(() => this.board.LoadRamValue()).Returns(this.savedValue);
        }

        public int LoadRamValue()
        {
            return this.board.LoadRamValue();
        }

        public void SaveRamValue(int value)
        {
            this.savedValue = value;
        }

        public void DrawOnVideoCard(string data)
        {
            this.board.DrawOnVideoCard(data);
        }
    }
}