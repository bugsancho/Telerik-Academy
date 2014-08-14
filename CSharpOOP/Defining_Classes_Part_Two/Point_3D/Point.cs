using System.Text;
   public struct Point
    {
       //fields
        private int xCoord;
        private int yCoord;
        private int zCoord;

        static readonly Point pointZero = new Point(0, 0, 0);
       //properties
        public int ZCoord
        {
            get
            {
                return zCoord;
            }
            set
            {
                zCoord = value;
            }
        }

        public int YCoord
        {
            get
            {
                return yCoord;
            }
            set
            {
                yCoord = value;
            }
        }
  	
        public int XCoord
        {
            get
            {
                return xCoord;
            }
            set
            {
                xCoord = value;
            }
        }

        public static Point PointZero
        {
            get { return pointZero; }
        }
       //constructor
        public Point(int xCoord, int yCoord, int zCoord) : this()
        {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
            this.ZCoord = zCoord;
        }
       //override method
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendFormat("X coord: {0}, ", xCoord);
            info.AppendFormat("Y coord: {0}, ", yCoord);
            info.AppendFormat("Z coord: {0}", zCoord);
            return info.ToString();
        }

    }