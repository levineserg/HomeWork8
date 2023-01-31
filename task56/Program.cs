// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void FillArrayWithRandom(int[,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArrayWithRandom(matrix, m, n);
int[] sum = new int[m];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        sum[i] += matrix[i, j];
    }
    Console.WriteLine($"Сумма в строке {i} = {sum[i]}");
}
int maxSum = sum[0];
int maxIndex = 0;
for (int i = 1; i < m; i++)
{
    if (sum[i] > maxSum)
    {
        maxSum = sum[i];
        maxIndex = i;
    }
}
Console.WriteLine($"Максимальная сумма в строке {maxIndex}");