//Напишите программу, которая принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N

Console.WriteLine("Введите свое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int antiNum = num * -1;
int res = 0;
while (num > antiNum)
{
    res = (int)num % 2;
    if ((int)res == 0)
    {
        Console.Write($"{num}, ");
    }
    num = num - 1;
}