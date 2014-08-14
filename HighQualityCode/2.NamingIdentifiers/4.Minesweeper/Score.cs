namespace Minesweeper
{
    using System;

    public class Score
    {
        private string holderName;
        private int points;

        public Score(string name, int points)
        {
            this.holderName = name;
            this.points = points;
        }

        public string HolderName
        {
            get
            {
                return this.holderName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Holder name cannot be null");
                }

                this.holderName = value;
            }
        }

        public int Points
        {
            get
            {
                return this.points;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Points cannot be negative!");
                }

                this.points = value;
            }
        }
    }
}
