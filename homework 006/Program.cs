// Напишите программу, которая на вход принимает трехзначное число, а на выходе показывает послеюнюю цифрц этого числа
// Типа 234 > 4

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
   res = num % 10;
   Console.WriteLine($"Ваше число {res}, милорд");
}