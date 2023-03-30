// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void PrintNumberToN(int N)
// {
// if(N == 0)
// {
// return;
// }
// System.Console.Write($"{N} ");
// PrintNumberToN(N - 1);
// }

// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// PrintNumberToN(number);


// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите M:");
// {
//     int m = int.Parse(Console.ReadLine());
//     Console.WriteLine("Введите N:");
//     int n = int.Parse(Console.ReadLine());

//     int sum = Sum(m, n);

//     Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна: {sum}");
// }

// int Sum(int m, int n)
// {
//     if (m == n)
//     {
//         return n;
//     }
//     else
//     {
//         return m + Sum(m+1, n);
//     }    
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.WriteLine("Введите m:");
// {
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите n:");
// int n = Convert.ToInt32(Console.ReadLine());

// int result = Ackermann(m, n);

// Console.WriteLine($"Результат функции Аккермана для m={m}, n={n} равен {result}");
// }

// int Ackermann(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0)
//     {
//         return Ackermann(m - 1, 1);
//     }
//     else
//     {
//         return Ackermann(m - 1, Ackermann(m, n - 1));
//     }
// }



