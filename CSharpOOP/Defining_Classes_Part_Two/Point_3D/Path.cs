using System;
using System.Collections.Generic;
using System.Collections;
class Path : IEnumerable
{
    //fields
    public readonly List<Point> points = new List<Point>();
    private static int count = 0;
    //property
    public int Count
    {
        get { return count; }
    }
    //methods
    public void Add(Point point)
    {
        points.Add(point);
        count++;
    }
    public void RemoveAt(int index)
    {
        if (index < points.Count && index >= 0)
        {
            points.RemoveAt(index);
            count--;
        }
        else
        {
            throw new ArgumentException();
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return points.GetEnumerator();
    }
}
