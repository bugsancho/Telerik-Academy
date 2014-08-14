using System;
class ForestRoad
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int height = inputNumber * 2 - 1;
            int dotsBefore = 0;
            int dotsAfter = inputNumber - dotsBefore - 1;
            for (int i = 0; i <= height/2; i++)
            {                                                         
              Console.Write(new string('.', dotsBefore));             
              Console.Write(new string('*', 1));                      
              Console.Write(new string('.', dotsAfter));              
              dotsBefore++;                                           
                dotsAfter = inputNumber - dotsBefore - 1;             
                Console.WriteLine();                                  
           }
            dotsBefore-= 2;
            dotsAfter += 2;          
            for (int i = 1; i <= height / 2; i++)                     
            {                                                         
                Console.Write(new string('.', dotsBefore));           
                Console.Write(new string('*', 1));                    
                Console.Write(new string('.', dotsAfter));            
                dotsBefore--;
                dotsAfter = inputNumber - dotsBefore - 1;
                Console.WriteLine();
            }

        }
    }

