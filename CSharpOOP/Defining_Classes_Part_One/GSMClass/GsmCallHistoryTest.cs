//Task solved:
//12.Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
//  Create an instance of the GSM class.
//  Add few calls.
//  Display the information about the calls.
//  Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
//  Remove the longest call from the history and calculate the total price again.
//  Finally clear the call history and print it.

class GsmCallHistoryTest
{
    public static void Test()
    {
        Gsm mobile = new Gsm("Galaxy", "Samsung");
        mobile.AddCall("0887583752", 45);
        mobile.AddCall("0887583752", 126);
        mobile.AddCall("0892834413", 3);
        mobile.AddCall("+359885741649", 334);
        mobile.AddCall("00889547414", 222);
        mobile.PrintAllCalls();
        mobile.PrintTotalCallCost(0.37);
        mobile.DeleteCall(3);
        mobile.PrintTotalCallCost(0.37);
        mobile.ClearCallHistory();
        mobile.PrintAllCalls();
    }
}