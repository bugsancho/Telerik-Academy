using System;

    class StringVariables
    {
        static void Main(string[] args)
        {
            String hello = "Hello ";
            String world = "world!";
            Object helloWorld = hello + world;
            string helloWorldAgain = (string)helloWorld;
            Console.WriteLine(helloWorld + "  <- Object representation");
            Console.WriteLine(helloWorldAgain + "  <- String representation");


        }
    }

