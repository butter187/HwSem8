﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);

// Console.WriteLine("Исходный массив: ");
// PrintArray(array);
// Console.WriteLine("Отсортированный массив: ");
// PrintArray(ChangeArray(array));


// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] res = new int[m, n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             res[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return res;
// }

// // -----------------Вывод массива-----------------
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// // -----------------Массив по возрастанию-----------------
// int[,] ChangeArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }

//     }

//     return array;
// }

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// 1, 2, 3

// 4, 6, 1

// 2, 1, 6

// 1 встречается 3 раза

// 2 встречается 2 раз

// 3 встречается 1 раз

// 4 встречается 1 раз

// 6 встречается 2 раза

// int[,] array = GetArray(4, 4, 0, 6);

// Console.WriteLine("Исходный массив: ");
// PrintArray(array);

// CountElement(array,1,2,3,4,5,6);


// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] res = new int[m, n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             res[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return res;
// }

// // -----------------Вывод массива-----------------
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// // -----------------Частотный словарь-----------------
// void CountElement(int[,] array, int x1, int x2, int x3, int x4, int x5, int x6)
// {
//     int count1 = 0;
//     int count2 = 0;
//     int count3 = 0;
//     int count4 = 0;
//     int count5 = 0;
//     int count6 = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
           
//             if (array[i,j]==x1)
//             {
//                 count1++;
//             }
//             if (array[i,j]==x2)
//             {
//                 count2++;
//             }
//             if (array[i,j]==x3)
//             {
//                 count3++;
//             }
//             if (array[i,j]==x4)
//             {
//                 count4++;
//             }
//             if (array[i,j]==x5)
//             {
//                 count5++;
//             }
//              if (array[i,j]==x6)
//             {
//                 count6++;
//             }
//         }
//     }
//     Console.WriteLine($"{x1} встречается {count1} раз");
//     Console.WriteLine($"{x2} встречается {count2} раз");
//     Console.WriteLine($"{x3} встречается {count3} раз");
//     Console.WriteLine($"{x4} встречается {count4} раз");
//     Console.WriteLine($"{x5} встречается {count5} раз");
//     Console.WriteLine($"{x6} встречается {count6} раз");
// }

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] matrix1 = GetArray(2, 2, 0, 9);

// Console.WriteLine("матрица №1: ");
// PrintArray(matrix1);

// int[,] matrix2 = GetArray(2, 2, 0, 9);
// Console.WriteLine("матрица №2: ");
// PrintArray(matrix2);

// Console.WriteLine("произведение 2 матриц : ");
// PrintArray(MultiplicationMatrix(matrix1, matrix2));

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] res = new int[m, n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             res[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return res;
// }

// // -----------------Вывод массива-----------------
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// // -----------------произведение 2 матриц-----------------
// int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
// {
//     int[,] newArray = new int[array1.GetLength(0), array1.GetLength(1)];
//     newArray[0, 0] = array1[0, 0] * array2[0, 0] + array1[0, 1] * array2[1, 0];
//     newArray[1, 0] = array1[1, 0] * array2[0, 0] + array1[1, 0] * array2[1, 0];
//     newArray[0, 1] = array1[0, 0] * array2[0, 1] + array1[0, 1] * array2[1, 1];
//     newArray[1, 1] = array1[1, 0] * array2[0, 1] + array1[1, 1] * array2[1, 1];
//     return newArray;
// }

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array = GetArray3D(2, 2, 2, 0, 99);

Console.WriteLine("Исходный массив: ");
PrintArray(array);

// -----------------Ввод массива-----------------
int[,,] GetArray3D(int m, int n, int g, int minValue, int maxValue)
{
    int[,,] res = new int[m, n, g];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            for (int k = 0; k < g; k++)
            { res[i, j, k] = GetUniqueValue(res, minValue, maxValue, i, j, k); }
        }
    }
    return res;
}

// -----------------Вывод массива-----------------
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j,k]}({i},{j},{k}) ");
            }

        }
        Console.WriteLine();
    }
}
// -----------------уникальный массив-----------------
int GetUniqueValue(int[,,] matrix, int min, int max, int i, int j, int k)
{
    Random rnd = new Random();
    int value = default;
    bool exist = true;
    while (exist)
    {
        bool _break = false;
        value = rnd.Next(min, max + 1);
        for (int i1 = 0; i1 < matrix.GetLength(0); i1++)
        {
            if (_break) { break; }
            for (int j1 = 0; j1 < matrix.GetLength(1); j1++)
            {
                if (_break) { break; }
                for (int k1 = 0; k1 < matrix.GetLength(2); k1++)
                {
                    if (matrix[i1, j1, k1] == value) { _break = true; break; }
                    if (i1 == i && j1 == j && k1 == k) { exist = false; }
                }
            }
        }
    }
    return value;
}
