using System;
class BitArrayTest
{
    static void Main()
    {
        BitArray firstArray = new BitArray(5);
        BitArray secondArray = new BitArray(5342457464354);
        BitArray thirdArray = new BitArray(5);
        Console.WriteLine(firstArray == secondArray);
        Console.WriteLine(firstArray == thirdArray);
        Console.WriteLine(firstArray[63]);
        Console.WriteLine(firstArray[62]);
        Console.WriteLine(secondArray.Number);
    }
}
