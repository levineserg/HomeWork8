// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1) 
// 1-й Вариант с ручным вводом
// void FillArray(int[] array, int arrayLength)
// {

//     for (int i = 0; i < arrayLength; i++)
//     {
//         Found:
//         Console.Write("Введите двузначное число: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//         if (array[i] < 10 || array[i] > 99)
//         {
//             Console.WriteLine("Это не двузначное число");
//             goto Found;
//         }

//         for (int j = 0;j < i; j++)
//         {
//             if (array[j] == array[i])
//             {
//                 Console.WriteLine("Такое число уже есть");
//                 goto Found;
//             }
//         }
//     }


// }

// void Fill3DArray(int[,,] newArray, int[] array, int m, int n, int p)
// {
//     int index = 0;
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             for (int k = 0; k < p; k++)
//             {

//                 newArray[i, j, k] = array[index];
//                 Console.Write($"{newArray[i, j, k]} ({i}, {j}, {k}) ");
//                 index++;
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Console.Write("Введите число m: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число p: ");
// int p = Convert.ToInt32(Console.ReadLine());
// int arrayLength = m * n * p;
// if (arrayLength > 90)
// {
//     Console.Write("Невозможно создать столько неповторяющихся двузначных чисел ");
// }
// else
// {
//     int[] array = new int[arrayLength];
//     int[,,] newArray = new int[m, n, p];
//     FillArray(array, arrayLength);
//     Fill3DArray(newArray, array, m, n, p);
// }

void FillArray(int[] array, int arrayLength)
{

    for (int i = 0; i < arrayLength; i++)
    {
    Found:

        array[i] = new Random().Next(10, 100);

        for (int j = 0; j < i; j++)
        {
            if (array[j] == array[i])
            {
                goto Found;
            }
        }
    }


}
void Fill3DArray(int[,,] newArray, int[] array, int m, int n, int p)
{
    int index = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {

                newArray[i, j, k] = array[index];
                Console.Write($"{newArray[i, j, k]} ({i}, {j}, {k}) ");
                index++;
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Write("Введите число m: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число p: ");
int p = Convert.ToInt32(Console.ReadLine());
int arrayLength = m * n * p;
if (arrayLength > 90)
{
    Console.Write("Невозможно создать столько неповторяющихся двузначных чисел ");
}
else
{
    int[] array = new int[arrayLength];
    int[,,] newArray = new int[m, n, p];
    FillArray(array, arrayLength);
    Fill3DArray(newArray, array, m, n, p);
}
