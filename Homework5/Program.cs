// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] FillArrayWhithRandomNumber(int size)
// {
// int[] arr = new int[size];
// Random rnd = new Random();
// for(int i = 0; i < arr.Length; i++)
// {
// arr[i] = rnd.Next(100, 1000);
// }
// return arr;
// }
// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWhithRandomNumber(size);


// int count = 0;
// foreach(int num in array) 
// {
//     if(num % 2 == 0)
//     {
//         count++;
//     }
// }
                  
// System.Console.Write("Ваш случайный массив: ");
// System.Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine($"В массиве {count} четных чисел.");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int[] FillArrayWhithRandomNumber(int size)
// {
// int[] arr = new int[size];
// Random rnd = new Random();
// for(int i = 0; i < arr.Length; i++)
// {
// arr[i] = rnd.Next(-99,100);
// }
// return arr;
// }
// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWhithRandomNumber(size);

// int sum = 0;
// for (int i = 1; i < size; i += 2) 
// {
//     sum += array[i];
// }

// System.Console.Write("Ваш случайный массив: ");
// System.Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine("Сумма элементов на нечётных позициях: {0}", sum);


// Задача 38:Задайте массив вещественных чисел(тип double). 
// Найдите разницу между максимальным и минимальным элементов массива.

// double[] arr = {3.4 , 5.8 , 1.2 , 7.8 , 5.6 , 9.7};

// double max = arr[0];
// double min = arr[0];
// for (int i = 1; i < arr.Length; i++)
// {
//     if (arr[i] > max) 
//     {
//         max = arr[i];
//     }
//     if (arr[i] < min) 
//     {
//         min = arr[i];
//     }
// }
// double diff = max - min;

// Console.WriteLine("Массив: {0}", string.Join(", ", arr));
// Console.WriteLine("Максимальный элемент: {0}", max);
// Console.WriteLine("Минимальный элемент: {0}", min);
// Console.WriteLine("Разница между максимальным и минимальным элементами: {0}", diff);