using System;
using System.Collections.Generic;
using System.Text;
public class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
{
    private T[,] matrix;
    //properties
    public int Columns
    {
        get { return this.matrix.GetLength(1); }
    }
    public int Rows
    {
        get { return this.matrix.GetLength(0); }
    }
    //constructor
    public Matrix(int row, int col)
    {
        this.matrix = new T[row,col];

    }
    //indexer
    public T this[int row, int col]
    {
        get { return this.matrix[row, col]; }
        set { this.matrix[row, col] = value; }
    }
    //method overloads
    public override string ToString()
    {
        StringBuilder info = new StringBuilder();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                info.AppendFormat("{0} ",matrix[i,j]);
            }
            info.AppendLine();
        }

        return info.ToString();
    }
    public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
    {
        if (firstMatrix.Rows == secondMatrix.Rows && firstMatrix.Columns == secondMatrix.Columns)
        {
            Matrix<T> sum = new Matrix<T>(firstMatrix.Rows, firstMatrix.Columns);
            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Columns; j++)
                {
                    sum[i, j] = (dynamic)firstMatrix[i, j] + (dynamic)secondMatrix[i, j];
                }
            }
            return sum;
        }
        else
        {
            throw new InvalidOperationException("Matrixes are not with equal dimensions!");
        }
    }
    public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
    {
        if (firstMatrix.Rows == secondMatrix.Rows && firstMatrix.Columns == secondMatrix.Columns)
        {
            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Columns);
            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Columns; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] - (dynamic)secondMatrix[i, j];
                }
            }
            return result;
        }
        else
        {
            throw new InvalidOperationException("Matrixes are not with equal dimensions!");
        }
    }
    public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
    {
        if (firstMatrix.Columns == secondMatrix.Rows)
        {
            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, secondMatrix.Columns);

            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Columns; col++)
                {
                    for (int currentIndex = 0; currentIndex < firstMatrix.Columns; currentIndex++)
                    {
                        result[row, col] += (dynamic)firstMatrix[row, currentIndex] * (dynamic)secondMatrix[currentIndex, col];
                    }
                }
            }
            return result;
        }
        else
        {
            throw new InvalidOperationException("Cannot multiply matrices with such dimensions!");
        }
    }
    public static bool operator true(Matrix<T> matrix)
    {
        if (matrix == null || matrix.Rows == 0 || matrix.Columns == 0)
        {
            return false;
        }
        for (int i = 0; i < matrix.Rows; i++)
        {
            for (int j = 0; j < matrix.Columns; j++)
            {
                if (!(dynamic)matrix[i, j].Equals(default(T)))
                {
                    return true;
                }
            }
        }
        return false;
    }
    public static bool operator false(Matrix<T> matrix)
    {
        if (matrix == null || matrix.Rows == 0 || matrix.Columns == 0)
        {
            return true;
        }
        for (int i = 0; i < matrix.Rows; i++)
        {
            for (int j = 0; j < matrix.Columns; j++)
            {
                if (!(dynamic)matrix[i, j].Equals(default(T)))
                {
                    return false;
                }
            }
        }
        return true;
    }
}