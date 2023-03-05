//Напишите программу, которая выводит случайное 
//трёхзначное число и удаляет вторую цифру этого числа.
/*
int CatNumber(int num)
{
    int hundreds = num / 100;
    int ones = num % 10;
    int result = hundreds * 10 + ones;
    return result;
}

int randNumber = new Random().Next(100, 1000);

int newNumber = CatNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/
//Напишите программу, которая принимает на вход число
// и проверяет, кратно ли оно одновременно a и b.
/*
bool isDivided(int number, int firstDivider, int secondDivider)
{
    if(number % firstDivider == 0 && number % secondDivider == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine("Input a number for checking: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a first divider: ");
int div1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second divider: ");
int div2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(isDivided(num, div1, div2));
*/