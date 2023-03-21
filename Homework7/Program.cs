// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// double[,] FillMatrixWithRandom(int row, int column)
// {
//     double[,] array = new double[row, column];
//     Random rnd = new Random();
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = Math.Round(rnd.NextDouble() + rnd.Next(-10, 10),1);
//         }
//     }
//     return array;
// }

//  void PrintMatrix(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//              Console.Write($"{array[i,j]} \t");  
//         }
//         Console.WriteLine();
//     }
    
// }

// Console.Write("Введите количество строк: ") ;
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// double[,] matrix = FillMatrixWithRandom(row, column);
// PrintMatrix(matrix);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


// int[,] array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

// Console.Write("Введите строку = ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите столбец = ");
// int column = Convert.ToInt32(Console.ReadLine());

// if (row >= array.GetLength(0) || column >= array.GetLength(1))
// {
//     Console.WriteLine("Введены некорректные значения индексов");
// }
// else
// {
//     int element = array[row, column];
//     Console.WriteLine($"Значение элемента [{row}, {column}] = {element}");
// }



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] arr = new int[,]
// {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// };

// int rows = arr.GetLength(0);
// int columns = arr.GetLength(1);

// int[] averages = new int[columns];

// for (int j = 0; j < columns; j++)
// {
//     int sum = 0;
//     for (int i = 0; i < rows; i++)
//     {
//         sum += arr[i, j];
//     }
//     averages[j] = (int)sum / rows;
// }

// for (int j = 0; j < columns; j++)
// {
//     Console.WriteLine($"Среднее арифметическое элементов в столбце {j} равно {averages[j]}");
// } 

