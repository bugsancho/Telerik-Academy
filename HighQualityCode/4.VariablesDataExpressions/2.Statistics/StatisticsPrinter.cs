using System;

public static class StatisticsPrinter
{
    public static void PrintStatisticalResult(double[] array, CalculationType calculation)
    {
        double result;
        string resultMessage;
        switch (calculation)
        {
            case CalculationType.Max:
                {
                    result = StatisticsCalculator.GetMax(array);
                    resultMessage = "The maximal element of the array is: ";
                }
                break;
            case CalculationType.Min:
                {
                    result = StatisticsCalculator.GetMin(array);
                    resultMessage = "The minimal element of the array is: ";
                }
                break;
            case CalculationType.Average:
                {
                    result = StatisticsCalculator.GetAverage(array);
                    resultMessage = "The average of the array is: ";
                }
                break;
            default:
                throw new ArgumentException("Unsupported calculation type!");
        }

        Console.WriteLine(resultMessage + result);
    }
}
