// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("введите (меньшее) число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите (большее) число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Эта программа работает, если число num2 > num1

// int SumOfNumbers(int num1, int num2)
// {
//     if (num1 != num2) return num2 + SumOfNumbers(num1, num2 -1);
//     return 0;
// }
// int sum = SumOfNumbers(num1, num2);
// Console.WriteLine(sum+num1); // самы простой костыль, до которого додумался

int SumOfNumbers(int num1, int num2)
{
    if (num1 <= num2) return num2 + SumOfNumbers(num1, num2 -1);
    return 0;
}
int sum = SumOfNumbers(num1, num2);
// Console.WriteLine(sum+num1); // самы простой костыль, до которого додумался
Console.WriteLine(sum);

