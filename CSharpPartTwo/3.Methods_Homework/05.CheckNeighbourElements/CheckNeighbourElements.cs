using System;
    class CheckNeighbourElements
    {
        //Write a method that checks if the element at given position 
        //in given array of integers is bigger than its two neighbors (when such exist).

        static void Main()
        {
            int[] array = new int[] { 5, 7, 6, 3, 8, 66, 3, 2, 5, 7, 9, 0, 22, 1, 4, 5 };
            Console.WriteLine("Please enter the index of the number you want to look up: ");
            int index = int.Parse(Console.ReadLine());
            Console.Write("The statement that the neighbouring elements of the number {0}, at index {1} are lesser is: ",array[index],index);
            Console.WriteLine(AreNeighbourElementsLesser(array, index));
        }

        private static bool isLeftElementLesser(int[] array, int index)
        {
            if (index > 0)
            {
                if (array[index] > array[index - 1])
                {
                    return true;
                }
                return false;
            }
            return true;
            
        }
        private static bool isRightElementLesser(int[] array, int index)
        {
            if (array[index] < array.Length-1)
            {
                if (array[index] > array[index +1])
                {
                    return true;
                }
                return false;
            }
            return true;
        }



        private static bool AreNeighbourElementsLesser(int[] array, int index)
        {
            return isLeftElementLesser(array,index) && isRightElementLesser(array, index);
        }

    }

