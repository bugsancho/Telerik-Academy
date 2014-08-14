using System;
    class QuadronacciRectangle
    {
        static void Main()
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            long thirdNumber = long.Parse(Console.ReadLine());
            long fourthNumber = long.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());            
            int numberOfColumns = int.Parse(Console.ReadLine());
            long nextElement = 0;
            Console.Write("{0} {1} {2} {3} ",firstNumber,secondNumber,thirdNumber,fourthNumber);
            
            for (int i = 0; i < numberOfLines ; i++)
            {
                if (i == 0)
                {
                    for (int J = 4; J < numberOfColumns; J++)
                    {

                        nextElement = firstNumber + secondNumber + thirdNumber + fourthNumber;
                        firstNumber = secondNumber;
                        secondNumber = thirdNumber;
                        thirdNumber = fourthNumber;
                        fourthNumber = nextElement;
                        Console.Write(nextElement);


                        if ((J + 1) >= numberOfColumns)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                else
                {
                    for (int J = 0; J < numberOfColumns; J++)
                    {

                        nextElement = firstNumber + secondNumber + thirdNumber + fourthNumber;
                        firstNumber = secondNumber;
                        secondNumber = thirdNumber;
                        thirdNumber = fourthNumber;
                        fourthNumber = nextElement;
                        Console.Write(nextElement);


                        if ((J + 1) >= numberOfColumns)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
                
               
            }
        }
        
    
}
