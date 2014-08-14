using System;
//A generic class that holds information about an exception that is not within some specified range.
class InvalidRangeException<T> : Exception
    where T : struct,IComparable
{
    //fields
    private T start;
    private T end;
    //properties
    public T End
    {
        get { return this.end; }
        private set { this.end = value; }
    }

    public T Start
    {
        get { return this.start; }
        private set { this.start = value; }
    }
    //constructors
    public InvalidRangeException(T start, T end, string message, Exception exception)
        : base(message, exception)
    {
        this.End = end;
        this.Start = start;
    }

    public InvalidRangeException(T start, T end, string message)
        : this(start, end, message, null)
    {
    }
    public InvalidRangeException(T start, T end)
        : this(start, end, null, null)
    {
    }
}
