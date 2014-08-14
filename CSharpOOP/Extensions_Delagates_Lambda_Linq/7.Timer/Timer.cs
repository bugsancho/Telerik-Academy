using System;
using System.Linq;
using System.Threading;
//a simple timer delegate class that takes a tick interval and total execution type and executes given method accordingly.
class Timer
{
    public delegate void MethodToExecute();

    //fields
        private MethodToExecute currentMethods;
        private int interval = 0;
        private int overalTime;
    //properties
        public int OveralTime
        {
            get
            {
                return this.overalTime;
            }
            set
            {
                this.overalTime = value * 1000;
            }
        }
        public int Interval
        {
            get
            {
                return this.interval;
            }
            set
            {
                this.interval = value;
            }
        }
        public MethodToExecute CurrentMethods
        {
            get
            {
                return this.currentMethods;
            }
            set
            {
                this.currentMethods = value;
            }
        }
    //constructor
        public Timer(int miliseconds, int totalSeconds)
        {
            this.OveralTime = totalSeconds;
            this.interval = miliseconds;
        }
    //method that executes the delegated method in given time interval.
        public void Execute()
        {
            DateTime start = DateTime.Now;
            DateTime end = start.AddMilliseconds(OveralTime);
            while (start <= end)
            {

                currentMethods();
                Thread.Sleep(Interval);
                start = DateTime.Now;
            }

        }
}
