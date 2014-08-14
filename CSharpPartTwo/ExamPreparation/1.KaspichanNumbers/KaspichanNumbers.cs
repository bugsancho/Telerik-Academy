using System;
using System.Collections.Generic;
class KaspichanNumbers
{
    //http://bgcoder.com/Contest/Practice/92

    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        List<string> digits = new List<string>();
        for (char i = 'A'; i <= 'Z'; i++)
        {
            digits.Add(i.ToString());
        }
        for (char i = 'a'; i <= 'i'; i++)
        {
            for (char j = 'A'; j <= 'Z'; j++)
            {
                digits.Add(i.ToString() + j.ToString());
            }
        }
        List<string> result = new List<string>();
        if (number == 0)
        {
            Console.WriteLine("A");
            return;
        }
        while (number > 0)
        {
            byte index = (byte)(number % 256);
            result.Add(digits[index]);
            number /= 256;

        }
        result.Reverse();
        foreach (var item in result)
        {
            Console.Write(item);
        }
    }
}
