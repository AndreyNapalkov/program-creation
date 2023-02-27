//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("ВВедите два числа ");   
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1>number2)
{
    Console.WriteLine(" {0}-наибольшое число",number1);
    Console.WriteLine(" {0}-наименьшее число",number2);
}
else
{
    Console.WriteLine(" {0}-наибольшое число",number2);
    Console.WriteLine(" {0}-наименьшее число",number1);
}

*/
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Введите три числа ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
 if (num1 > num2)
    {
        if (num1 > num3)
        {
            Console.Write(" {0}-max",num1);
        }
        else
        {
            Console.Write(" {0}-max",num3);
        }
    }
    else if (num2 > num3)
        Console.Write(" {0}-max",num2);
    else
        Console.Write(" {0}-max",num3);
        */
        // Напишите программу, которая на вход принимает число и выдаёт,
        // является ли число чётным (делится ли оно на два без остатка).

/*Console.WriteLine("Введите число " );
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 == 0)
{
    Console.Write(" {0}-четное",num);
}
else
{
    Console.Write(" {0}-нечетное",num);
}
*/
// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;
while (current <= num)
{
    if(current % 2 == 0)
    {
        Console.Write(current + " ");
    }
    current++;
}
*/




