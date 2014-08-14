using System;
using System.Collections.Generic;
using System.Linq;

public static class IEnumerableExtension
{
    //Min and Max extension methods that take an IComparable and return the minimal or maximal T(IComparable) element using .CompareTo()
    public static T Min<T>(this IEnumerable<T> collection) where T : IComparable,IConvertible
    {
        if (collection.Count() != 0)
        {
            bool isFirstMember = true;
            dynamic min = 0;
            foreach (var number in collection)
            {
                if (isFirstMember)
                {
                    min = number;
                    isFirstMember = false;
                    continue;
                }
                else
                {
                    if (min.CompareTo(number) > 0)
                    {
                        min = number;
                    }
                }
            }
            return min;
        }
        else
        {
            throw new NullReferenceException();
        }

    }
    public static T Max<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
    {
        if (collection.Count() != 0)
        {
            bool isFirstMember = true;
            dynamic max = 0;
            foreach (var number in collection)
            {
                if (isFirstMember)
                {
                    max = number;
                    isFirstMember = false;
                    continue;
                }
                else
                {
                    if (max.CompareTo(number) < 0)
                    {
                        max = number;
                    }
                }
            }
            return max;
        }
        else
        {
            throw new NullReferenceException();
        }
    }
    //Sum, Average and Product extension methods that take an IComparable struct (basicaly, a number type) and calculate using (and returning) dynamic types to avoid overflowing.
    public static dynamic Sum<T>(this IEnumerable<T> collection) where T : struct, IComparable, IConvertible
    {
        if (collection.Count() != 0)
        {
            dynamic sum = 0;
            foreach (var number in collection)
            {
                sum += number;
            }
            return sum;
        }
        else
        {
            throw new NullReferenceException();
        }
    }
    public static dynamic Average<T>(this IEnumerable<T> collection) where T : struct, IComparable, IConvertible
    {
        if (collection.Count() != 0)
        {
            dynamic sum = 0.0;
            dynamic counter = 0;
            foreach (var number in collection)
            {
                sum += number;
                counter++;
            }
            dynamic average = sum / counter;
            return average;
        }
        else
        {
            throw new NullReferenceException();
        }
    }
    public static dynamic Product<T>(this IEnumerable<T> collection) where T : struct, IComparable, IConvertible
    {
        if (collection.Count() != 0)
        {
            dynamic product = 1.0;
            foreach (var number in collection)
            {
                if (number.CompareTo(0) == 0)
                {
                    return 0;
                }
                else
                {
                    product *= number;
                }
            }
            return product;
        }
        else
        {
            throw new NullReferenceException();
        }
    }
}
