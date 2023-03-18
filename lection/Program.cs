/*int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = {11, 23, 56, 89, 23, 56 ,22, 11, 33};
array[0] = 12;
Console.WriteLine(array[4]);


int[] array = {1, 2, 4, 45, 67, 78, 23, 56 }; 

int n = array.Length;
int find = 4; 

int index = 0;

while (index < n)
{
   if(array[index] == find)
   {
    Console.WriteLine(index);
   } 
   index++;
}
*/
// void FillArray



// int[] array = new int[10]

// Дан текст. В тексте нужно все пробелы заменить черточками,
//  маленькие буквы к заменить большими К , 
//  а большие С заменить на маленькие с.

// string text = "- Я думаю, - сказал князь, улыбаясь, - что";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int Length = text.Length;
//     for (int i = 0; i < Length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;

// }
// String newText = Replace(text, ' ', '@');
// Console.WriteLine(newText);

string[,] table = new string[2, 5];
// String.Empty
table[1, 2] = "слово";

for(int rows = 0; rows < 2; rows++)
{
    for(int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}

int[,] matrix= new int [3]