using System;
using System.Collections;
using System.Collections.Generic;
//a class that is used to easily find the binary representation of a ulong number.
class BitArray : IEnumerable<int>
{
    //readonly number
    private readonly ulong number;
    //constructor
    public BitArray(ulong number)
    {

        this.number = number;
    }
    //get properties
    public ulong Number
    {
        get
        {
            return this.number;
        }

    }
    public int[] Bits
    {
        get
        {
            return this.ConvertToArray();
        }
    }
    //enumerator
    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public IEnumerator<int> GetEnumerator()
    {
        int[] bitArray = this.ConvertToArray();

        for (int i = 0; i < bitArray.Length; i++)
        {
            yield return bitArray[i];
        }
    }
    //private method that does the bussiness
    private int[] ConvertToArray()
    {
        ulong tempNumber = this.number;

        int[] bits = new int[64];
        int counter = 63;

        while (tempNumber != 0)
        {
            bits[counter] = (int)tempNumber % 2;
            tempNumber /= 2;
            counter--;
        }

        do
        {
            bits[counter] = 0;
            counter--;
        }
        while (counter != 0);

        return bits;
    }
    //indexer
    public int this[int index]
    {
        get
        {
            if (index < 0 || index > 63)
            {
                throw new System.IndexOutOfRangeException();
            }
            else
            {
                int[] bits = this.ConvertToArray();
                return bits[index];
            }
        }
    }

    //override methods
    public bool Equals(BitArray array)
    {
        if (ReferenceEquals(null, array))
        {
            return false;
        }
        if (ReferenceEquals(this, array))
        {
            return true;
        }
        return this.number == array.number;
    }

    public override bool Equals(object obj)
    {
        BitArray array = obj as BitArray;
        if (array == null)
            return false;
        return this.Equals(array);
    }

    public override int GetHashCode()
    {
        return this.number.GetHashCode() ^ 879534;

    }



    public static bool operator ==(BitArray first, BitArray second)
    {
        return BitArray.Equals(first, second);
    }

    public static bool operator !=(BitArray first, BitArray second)
    {
        return !BitArray.Equals(first, second);
    }
}