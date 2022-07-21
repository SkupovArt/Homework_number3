//Напишите программу, которая на вход принимает число и выдает, является ли оно четным (делится ли без остатка)
Console.WriteLine("Введите свое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int res = (int)num % 2;
if((int)res == 0)
{
    Console.WriteLine($"Число {num} является четным");
}
else
{
    Console.WriteLine($"Число {num} не является четным");
}