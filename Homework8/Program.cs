// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] FillMatrixWithRandom(int row, int column)
// {
// int[,] array = new int[row, column];
// Random rnd = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i, j] = rnd.Next(0, 10);
// }
// }
// return array;
// }

// void PrintMatrix(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write($"{array[i, j]} \t");
// }
// Console.WriteLine();
// }
// }
// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixWithRandom(row, column);
// PrintMatrix(matrix);
// Console.WriteLine();

// for (int i = 0; i < matrix.GetLength(0); i++) 
// {
//     for (int j = 0; j < matrix.GetLength(1) - 1; j++) 
//     {
//         for (int k = j + 1; k < matrix.GetLength(1); k++) 
//         {
//             if (matrix[i, j] < matrix[i, k]) 
//             {
//                 int temp = matrix[i, j]; 
//                 matrix[i, j] = matrix[i, k];
//                 matrix[i, k] = temp;
//             }
//         }
//     }
// }

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} \t");
//     }
//     Console.WriteLine();
// }    

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] FillMatrixWithRandom(int row, int column)
// {
// int[,] array = new int[row, column];
// Random rnd = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i, j] = rnd.Next(0, 10);
// }
// }
// return array;
// }

// void PrintMatrix(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write($"{array[i, j]} \t");
// }
// Console.WriteLine();
// }
// }
// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixWithRandom(row, column);
// PrintMatrix(matrix);
// Console.WriteLine();

// int minSumIndex = 0;
// int minSum = int.MaxValue;

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     int sum = 0; 
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         sum += matrix[i, j];
//     }
//     if (sum < minSum)
//     {
//         minSumIndex = i;
//         minSum = sum;
//     }
// }
// Console.WriteLine($"В данной матрице, строка с наименьшой суммой под номером ({minSumIndex+1}), сумма данной строки равна {minSum}");




// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] arr = new int[2,2,2] { {{11,12},{13,14}}, {{15,16},{17,18}} };

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         for (int k = 0; k < arr.GetLength(2); k++)
//         {
//             Console.WriteLine($"{arr[i, j, k]}:({i},{j},{k}) ");
//         }
//     }
// }        