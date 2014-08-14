using System;

namespace _7.ReadAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("How old are you? ");
            age = int.Parse(Console.ReadLine());
            age = age + 10;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("In ten years you'll be {0} years old!", age);
            Console.WriteLine("------------------------------------");
        }
    }
}
