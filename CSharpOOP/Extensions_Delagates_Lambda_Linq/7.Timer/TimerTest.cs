using System;
static class TimerTest
{
    static void Main()
    {
        Timer timer = new Timer(1500, 10);
            timer.CurrentMethods = TestMetnod;
            timer.Execute();
    }
    public static void TestMetnod()
        {
            Console.WriteLine("This message appears every few seconds!");
        }
}