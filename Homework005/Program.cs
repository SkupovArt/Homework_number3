//Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N
Console.WriteLine("Введите свое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int res = 0;
while (num > 1)
{
    res = (int)num % 2;
    if ((int)res == 0)
    {
        Console.Write($"{num}, ");
    }
    num = num - 1;
}