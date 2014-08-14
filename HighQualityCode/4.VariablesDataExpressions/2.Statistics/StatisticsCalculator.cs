using System;

public static class StatisticsCalculator
{
    public static double GetMax(double[] array)
    {
        if (array == null)
        {
            throw new ArgumentNullException("The array parameter cannot be null!");
        }

        double maxElement = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
            }
        }

        return maxElement;
    }

    public static double GetMin(double[] array)
    {
        if (array == null)
        {
            throw new ArgumentNullException("The array parameter cannot be null!");
        }

        double minElement = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minElement)
            {
                minElement = array[i];
            }
        }

        return minElement;
    }

    public static double GetAverage(double[] array)
    {
        if (array == null)
        {
            throw new ArgumentNullException("The array parameter cannot be null!");
        }

        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        double average = sum / array.Length;
        return average;
    }
}
