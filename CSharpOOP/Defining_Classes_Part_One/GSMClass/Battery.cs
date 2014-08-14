using System;
using System.Text;

// Tasks solved:
//3.Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.

public enum BatteryType
{
    LiIon,
    NiMh,
    NiCd
};
class Battery
{
    //Constructors that take a range of parameters
    public Battery(BatteryType batteryType, string model, int? hoursIdle, int? hoursTalk)
    {
        this.BatteryType = batteryType;
        this.Model = model;
        this.HoursIdle = hoursIdle;
        this.HoursTalk = hoursTalk;
    }

    public Battery(BatteryType batteryType, string model, int? hoursIdle)
        : this(batteryType, model, hoursIdle, null)
    {
    }
    public Battery(BatteryType batteryType, string model)
        : this(batteryType, model, null, null)
    {
    }
    public Battery(BatteryType batteryType)
        : this(batteryType, null, null, null)
    {
    }

    //properties with entry data validation where possible(logical)
    private string model;
    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            this.model = value;
        }
    }
    //the hoursIdle and hoursTalk parameters are optional so they can be either null(not entered) or greater than zero.
    private int? hoursIdle;
    public int? HoursIdle
    {
        get
        {
            return this.hoursIdle;
        }
        set
        {
            if (value > 0 || value == null)
            {
                this.hoursIdle = value;
            }
            else
            {
                throw new ArgumentException("The parameter for hours idle cannot be less or equal to zero!");
            }
        }
    }

    private int? hoursTalk;
    public int? HoursTalk
    {
        get
        {
            return this.hoursTalk;
        }
        set
        {
            if (value > 0 || value == null)
            {
                this.hoursTalk = value;
            }
            else
            {
                throw new ArgumentException("The parameter for hours talk cannot be less or equal to zero!");
            }
        }
    }

    private BatteryType batteryType;
    public BatteryType BatteryType
    {
        get
        {
            return batteryType;
        }
        set
        {
            this.batteryType = value;
        }
    }
    //Override method to display proper information about the battery
    public override string ToString()
    {
        StringBuilder info = new StringBuilder();
        info.AppendFormat("Type: {0} ",batteryType);
        if (model != null)
        {
            info.AppendFormat("Model: {0} ",model);
        }
        if (hoursIdle != null)
        {
            info.AppendFormat("HoursIdle: {0} ",hoursIdle);
        }
        if (hoursTalk != null)
        {
            info.AppendFormat("HoursTalk: {0} ", hoursTalk);
        }
        return info.ToString();
    }
}