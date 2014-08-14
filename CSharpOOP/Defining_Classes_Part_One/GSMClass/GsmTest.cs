using System;
//Tasks solved:
//Write a class GSMTest to test the GSM class:
//  Create an array of few instances of the GSM class.
//  Display the information about the GSMs in the array.
//  Display the information about the static property IPhone4S.

class GsmTest
{
    static void Main()
    {
        Gsm[] phones = new Gsm[5];
        phones[0] = new Gsm("Iphone", "Apple", 1500);
        phones[1] = new Gsm("Lumia", "Nokia", 700,"Conio",new Battery(BatteryType.LiIon,"BC5326",300,10));
        phones[2] = Gsm.Iphone;
        phones[3] = new Gsm("S4", "Samsung", 1200, "Maria", new Battery(BatteryType.LiIon, "BL-5CB", 360),new Display(5));
        phones[4] = new Gsm("6600", "Nokia");
        foreach (var phone in phones)
        {
            Console.WriteLine(phone);
        }
        phones[4].Battery = new Battery(BatteryType.NiMh);
        phones[4].Owner = "Me";
        phones[4].Display = new Display(2, 16000);
        phones[4].Display.Size = 5;
        Console.WriteLine(phones[4]);

        GsmCallHistoryTest.Test();
    }
}
