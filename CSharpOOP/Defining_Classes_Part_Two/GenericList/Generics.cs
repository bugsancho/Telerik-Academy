using System;
using System.Collections.Generic;

class Generics
{
    //tests for the GenericList class
    static void Main()
    {
        GenericList<int> list = new GenericList<int>(5);
        Console.WriteLine(list.Capacity);
        list.Add(1);
        list.Add(64);
        Console.WriteLine(list.Count);
        list.Add(75);
        list.Add(-5);
        list.Add(4);
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
        list.Clear();
        Console.WriteLine();
        list.InsertAt(2, 5);
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
        Console.WriteLine(list.Count);
        Console.WriteLine(list.Capacity);
    }
}