// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
void FillArrayWithRandom(int[,] matrix, int row, int columns)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(-9, 10);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void ProductMatrix(int[,] matrix1, int[,] matrix2, int[,] productMatrix, int m, int n, int l)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                productMatrix[i, j] += matrix1[i, k] * matrix2[k, j];

            }
            Console.Write(productMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Задайте количество строк  первого массива : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов  второго массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов первого массива и строк второго массива: ");
int l = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[m, l];
int[,] matrix2 = new int[l, n];
int row = m;
int columns = l;
Console.WriteLine("Первая матрица ");
FillArrayWithRandom(matrix1, row, columns);
row = l;
columns = n;
Console.WriteLine("Вторая  матрица ");
FillArrayWithRandom(matrix2, row, columns);
int[,] productMatrix = new int[m, n];
Console.WriteLine("Произведение матриц ");
ProductMatrix(matrix1, matrix2, productMatrix, m, n, l);