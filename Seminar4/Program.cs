// Напишите программу, которая принимает на вход число (А)
//  и выдаёт сумму чисел от 1 до А

// int Sum(int A)
// {
//     int sum = 0;
//     for(int i = 1; i <= A; i++)
//     {
//         sum+=i; //sum = sum + i
//     }
//     return sum;
// }

// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = Sum(number);
// System.Console.WriteLine($"Сумма от 1 до {number} = {sum}");

// Напишите программу которая принимает на
//  вход число N выдает произведение чисел от 1 до N.


// int Composition(int A)
// {
//     int composition = 1;
//     for(int i = 1; i <= A; i++)
//     {
//         composition*=i; //sum = sum + i
//     }
//     return composition;
// }

// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int composition = Composition(number);
// System.Console.WriteLine($"Произведение от 1 до {number} = {composition}");

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int Counting(int number)
// {
// int count = 0;
// while(number != 0)// == проверка на равенство, != проверка на неравенство
// {
// number/=10;
// count++;
// }
// return count;

// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine()); // int number = Math.Abs(Convert.ToInt32(Console.ReadLine())) - модуль числа
// int count = Counting(number);
// System.Console.WriteLine($"Цифр в нашем числе {number} = {count}");

//  Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// // [1,0,1,1,0,1,0,0]

// int[] FillArray(int size)
// {
// int[] arr = new int[size];
// Random rnd = new Random();
// for(int i = 0; i < arr.Length; i++)
// {
// arr[i] = rnd.Next(0, 2);
// }
// return arr;
// }

// System.Console.Write("Введите кол-во элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(size);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");


