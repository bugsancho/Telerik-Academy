using System;
    class TribunacciTriangle
    {
        static void Main()
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            long thirdNumber = long.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());
            long nextElement = 0;
            int numberOfColumns = 3;
            Console.WriteLine(firstNumber);
            Console.WriteLine("{0} {1}",secondNumber,thirdNumber);
            
            for (int i = 0; i < numberOfLines -2 ; i++)
            {              
                for (int J = 0; J < numberOfColumns; J++)
                {                  
                        nextElement = firstNumber + secondNumber + thirdNumber;
                        firstNumber = secondNumber;
                        secondNumber = thirdNumber;
                        thirdNumber = nextElement;
                        Console.Write(nextElement);
                    
                    if ((J + 1) >= numberOfColumns)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                numberOfColumns++;
               
            }
        }
    
}


