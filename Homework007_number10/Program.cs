// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = 0;
if (num > 999 )
{
    Console.WriteLine("ваше число не трехзначное");
}
else if (num < 100)
{
    Console.WriteLine("ваше число не трехзначное");
}
else
{
   res = num / 10 % 10;
   Console.WriteLine($"ваше число: {res}");

}