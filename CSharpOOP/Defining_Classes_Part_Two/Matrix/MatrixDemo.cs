class MatrixDemo
{
    static void Main()
    {
        Matrix<int> matrix = new Matrix<int>(5,3);
        matrix[1, 1] = -5;
        Matrix<int> second = new Matrix<int>(5, 3);
        second[1, 1] = 2;
        System.Console.WriteLine(second);
        second = matrix - second;
        System.Console.WriteLine(second);
        Matrix<int> mat = new Matrix<int>(2, 2);
        Matrix<int> multy = new Matrix<int>(2, 3);
        mat[1, 1] = 5;
        multy[1, 0] = 3;
        System.Console.WriteLine(multy);
        System.Console.WriteLine(mat*multy);
    }
}