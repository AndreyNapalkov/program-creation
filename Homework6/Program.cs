// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


// Console.Write("Введите количество чисел: ");
// int count = Convert.ToInt32(Console.ReadLine());

// int positiveCount = 0;

// for (int i = 0; i < count; i++) 
// {
//     Console.Write($"Введите {i+1}-е число: ");
//     int num = Convert.ToInt32(Console.ReadLine());

//     if (num > 0) 
//     {
//         positiveCount++;
//     }
// }
// Console.WriteLine($"Количество чисел больше 0: {positiveCount}");
// Console.ReadLine();


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите уравнение первой прямой (y = k1 * x + b1):");
// Console.Write("k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите уравнение второй прямой (y = k2 * x + b2):");
// Console.Write("k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// if (k1 == k2) 
// {
//     Console.WriteLine("Прямые параллельны, точек пересечения нет");
// } 
// else 
// {
//     double x = (b2 - b1) / (k1 - k2);
//     double y = k1 * x + b1;

//     Console.WriteLine($"Точка пересечения прямых: ({x}, {y})");
// }