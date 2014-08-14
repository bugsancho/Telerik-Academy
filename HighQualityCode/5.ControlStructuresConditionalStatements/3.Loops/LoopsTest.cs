using System;
    class LoopsTest
    {
        static void Main(int[] array, int expectedValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        Console.WriteLine("Value Found");
                    }
                }
            }
        }
    }

