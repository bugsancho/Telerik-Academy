using System;
using System.Text;
//Tasks solved:
//8.Create a class Call to hold a call performed through a GSM. It should contain date, time, dialed phone number and duration (in seconds).
//9.Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to use the system class List<Call>.

class Call
{
    //constructor that takes the dialed number, the duration in seconds and adds the current time as a property.
    public Call(string dialedNumber, int duration)
    {
        this.TimeStamp = DateTime.Now;
        this.DialedNumber = dialedNumber;
        this.Duration = duration;
    }

    private DateTime timeStamp;
    public DateTime TimeStamp
    {
        get
        {
            return timeStamp;
        }
        private set
        {
            this.timeStamp = value;
        }
    }
    //a phone number(in Bulgaria) can be between 10 and 14 digits long, depending how it is entered
    private string dialedNumber;
    public string DialedNumber
    {
        get
        {
            return dialedNumber;
        }
        private set
        {
            if (value.Length >= 10 && value.Length <=14)
            {
                this.dialedNumber = value; 
            }
            else
            {
                throw new ArgumentException("The number must be between 10 and 14 digits long!");
            }
                
        }
    }
    //the duration of a call cannot be a non-positive value
    private int duration;
    public int Duration
    {
        get
        {
            return duration;
        }
        private set
        {
            if (value > 0)
            {
                this.duration = value;
            }
            else
            {
                throw new ArgumentException("Duration cannot be less or equal to zero!");
            }
            
        }
    }
    //override method for displaying proper info about the call.
    public override string ToString()
    {
        StringBuilder info = new StringBuilder();
        info.AppendFormat("Time of call: {0},\n", timeStamp.ToString("yyyy.MM.dd HH:mm:ss"));
        info.AppendFormat("Dialed number: {0},\n", dialedNumber);
        info.AppendFormat("Call duration: {0} seconds.\n", duration);
        return info.ToString();
    }
}