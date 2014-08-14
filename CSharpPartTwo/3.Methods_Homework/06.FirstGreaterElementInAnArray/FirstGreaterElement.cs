using System;
    class FirstGreaterElement
    {
        //Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
        //Use the method from the previous exercise.

        static void Main()
        {
            int[] array = new int[] { 5, 7, 8, 10, 8, 9, 13, 2, 4, 5, 9, 12 };
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (AreNeighbourElementsLesser(array,i))
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine("The first number in the array that is greater than its neighbours is {0}, found at index {1}!",array[index],index);
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
            if (array[index] < array.Length - 1)
            {
                if (array[index] > array[index + 1])
                {
                    return true;
                }
                return false;
            }
            return true;
        }



        private static bool AreNeighbourElementsLesser(int[] array, int index)
        {
            return isLeftElementLesser(array, index) && isRightElementLesser(array, index);
        }
    }

