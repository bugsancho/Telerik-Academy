using System.Text;
using System;
using System.Collections.Generic;
//Tasks solved:
//1.Define a class that holds information about a mobile phone device: model, manufacturer, price, 
//owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors). 

//2.Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it). 
//Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.

//4.Add a method in the GSM class for displaying all information about it. Try to override ToString().

//5.Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. Ensure all fields hold correct data at any given time.

//6.Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.

//10.Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.

//11.Add a method that calculates the total price of the calls in the call history. Assume the price per minute is fixed and is provided as a parameter.


class Gsm
{
    //constructors that take a variety of parameters
    public Gsm(string model, string manufacturer, int? price, string owner, Battery battery, Display display)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Price = price;
        this.Owner = owner;
        this.Battery = battery;
        this.Display = display;
    }
    public Gsm(string model, string manufacturer, int price, string owner, Battery battery)
        : this(model, manufacturer, price, owner, battery, null)
    {
    }
    public Gsm(string model, string manufacturer, int price, string owner)
        : this(model, manufacturer, price, owner, null, null)
    {
    }
    public Gsm(string model, string manufacturer, int price)
        : this(model, manufacturer, price, null, null, null)
    {
    }
    public Gsm(string model, string manufacturer)
        : this(model, manufacturer, null, null, null, null)
    {
    }



    static Gsm()
    {
        iphone = new Gsm("Iphone 4s", "Apple", 1500, "Somebody", new Battery(BatteryType.LiIon, "Unknown", 200, 14), new Display(3.5, 15000000));

    }

    //static field holding information about the Iphone 4s
    private static Gsm iphone;
    public static Gsm Iphone
    {
        get
        {
            return iphone;
        }
    }

    //properties with entry data validation where possible(logical)
    private string model;
    public string Model
    {
        get
        {
            return this.model;
        }
        private set
        {
            this.model = value;
        }
    }

    //the manufacturer is mandatory so the length cannot be 0 and logically neither 1 or 2.
    private string manufacturer;
    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        private set
        {
            if (value.Length > 2)
            {
                this.manufacturer = value;
            }
            else
            {
                throw new ArgumentException("Manufacturer name cannot be less than three symbols long");
            }
            this.manufacturer = value;
        }
    }

    //the price is optional so it can be either null(not entered) or greater than zero.
    private int? price;
    public int? Price
    {
        get
        {
            return this.price;
        }
        private set
        {
            if (value > 0 || value == null)
            {
                this.price = value;
            }
            else
            {
                throw new ArgumentException("The price cannot be less or equal to zero!");
            }
        }
    }

    //The owner is an optional paremeter so no validation is possible.
    private string owner;
    public string Owner
    {
        get
        {
            return this.owner;
        }
        set
        {
            this.owner = value;
        }
    }

    //The battery is optional so no validation is possible
    private Battery battery;
    public Battery Battery
    {
        get
        {
            return this.battery;
        }
        set
        {
            this.battery = value;
        }
    }

    //Same goes for the display
    private Display display;
    public Display Display
    {
        get
        {
            return this.display;
        }
        set
        {
            this.display = value;
        }
    }

    //A property that holds the call history of the GSM
    private List<Call> callHistory = new List<Call>();
    public List<Call> CallHistory
    {
        get { return this.callHistory; }
    }


    //display information about the GSM, overriding ToString()
    public override string ToString()
    {
        StringBuilder info = new StringBuilder();
        info.AppendFormat("Model: {0}\n", model);
        info.AppendFormat("Manufacturer: {0}\n", manufacturer);
        if (price != null)
        {
            info.AppendFormat("Price: {0}\n", price);
        }
        if (owner != null)
        {
            info.AppendFormat("Owner: {0}\n", owner);
        }
        if (battery != null)
        {
            info.AppendFormat("Battery: {0}\n", battery);
        }
        if (display != null)
        {
            info.AppendFormat("Display: {0}\n", display);
        }

        return info.ToString();
    }

    //add a call by reading the number that is to be called, duration of the call and converting the given inforamtion to a Call type and adding it to the list of calls.
    public void AddCall(string dialedNumber, int duration)
    {
        Call call = new Call(dialedNumber, duration);
        callHistory.Add(call);
    }

    //print all calls if there are any, else print corresponding message
    public void PrintAllCalls()
    {
        if (callHistory.Count == 0)
        {
            Console.WriteLine("The call history is empty!");
        }
        else
        {
            Console.WriteLine("Call History:");
            for (int counter = 0; counter < callHistory.Count; counter++)
            {
                Call currentCall = callHistory[counter];
                Console.Write("{0}. ", counter);
                Console.WriteLine(currentCall);
            }
        }
    }

    //clear the list of calls
    public void ClearCallHistory()
    {
        CallHistory.Clear();
    }

    //delete a call by its index in the list.By default the method deletes the first call if no index is entered. The index could be seen by using the PrintAllCalls() method
    public void DeleteCall(int index = 0)
    {
        //PrintAllCalls();
        //Console.WriteLine("Please enter the index of the call you wish to erase");
        //int index = int.Parse(Console.ReadLine());
        callHistory.RemoveAt(index);
    }

    //calculate the total cost of the calls by given price per minute as parameter, assuming billing occurs at the beginning of every minute.
    public void PrintTotalCallCost(double callPrice)
    {
        double totalCost = 0;
        foreach (Call call in callHistory)
        {
            totalCost += (call.Duration / 60) * callPrice;
            if (call.Duration % 60 != 0)
            {
                totalCost += callPrice;
            }
        }
        Console.WriteLine("Total call cost: {0}", totalCost);
    }
}
