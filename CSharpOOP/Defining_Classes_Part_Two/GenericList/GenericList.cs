using System.Text;
using System.Collections;
using System;
public class GenericList<T> where T : IComparable, IComparable<T>
{
    private T[] array;
    private int currentIndex = 0;
    //properties
    public int Count
    {
        get { return this.currentIndex; }
    }
    public int Capacity
    {
        get { return this.array.Length; }
    }
    public T this[int index]
    {
        get
        {
            return this.array[index];
        }
    }
    //constructor
    public GenericList(int arraySize)
    {
        this.array = new T[arraySize];
    }
    //methods
    public void Add(T element)
    {
        if (this.currentIndex >= this.array.Length)
        {
            ResizeArray();
        }
        this.array[currentIndex] = element;
        currentIndex++;
    }

    private void ResizeArray()
    {
        T[] newArray = new T[this.array.Length * 2];
        for (int i = 0; i < this.array.Length; i++)
        {
            newArray[i] = this.array[i];
        }
        this.array = newArray;
    }

    public T Min()
    {
        if (this.array.Length != 0)
        {
            T minElement = this.array[0];
            for (int i = 1; i < this.array.Length; i++)
            {
                if (minElement.CompareTo(this.array[i]) > 0)
                {
                    minElement = this.array[i];
                }
            }
            return minElement;
        }
        else
        {
            throw new NullReferenceException();
        }
    }

    public T Max()
    {
        if (this.array.Length != 0)
        {

            T maxElement = this.array[0];
            for (int i = 1; i < this.array.Length; i++)
            {
                if (maxElement.CompareTo(this.array[i]) < 0)
                {
                    maxElement = this.array[i];
                }
            }
            return maxElement;
        }
        else
        {
            throw new NullReferenceException();
        }
    }
    public void RemoveAt(int index)
    {
        if (index < this.array.Length && index >= 0)
        {
            T[] tempArray = new T[this.array.Length];
            for (int i = 0; i < this.array.Length - 1; i++)
            {
                if (i < index)
                {
                    tempArray[i] = this.array[i];
                }
                else
                {
                    tempArray[i] = this.array[i + 1];
                }
            }
            this.array = tempArray;
            currentIndex--;
        }
        else
        {
            throw new ArgumentException("Index is out of range!");
        }
    }
    public void InsertAt(int index, T element)
    {
        if (index < this.array.Length && index >= 0)
        {
            if (this.currentIndex + 1 >= this.array.Length)
            {
                ResizeArray();
            }

            T[] tempArray = new T[this.array.Length];
            bool firstIteration = true;
            for (int i = 0; i < this.array.Length - 1; i++)
            {
                if (i < index)
                {
                    tempArray[i] = this.array[i];
                }
                else if (i == index && firstIteration)
                {
                    tempArray[i] = element;
                    firstIteration = false;
                    i--;
                }
                else
                {
                    tempArray[i + 1] = this.array[i];
                }
            }
            this.array = tempArray;
            currentIndex++;
        }
        else
        {
            throw new ArgumentException("Index is out of range!");
        }
    }
    public void Clear()
    {
        this.array = new T[this.array.Length];
    }
    public int IndexOf(T element)
    {
        for (int i = 0; i < this.array.Length; i++)
        {
            if (this.array[i].CompareTo(element) == 0)
            {
                return i;
            }
        }
        return -1;
    }
    public override string ToString()
    {
        StringBuilder info = new StringBuilder();
        foreach (var item in this.array)
        {
            info.AppendFormat("{0}, ", item);
        }
        return info.ToString();
    }
}