// Напишите программу которая на вход принимает два числа и выдает какое число больше, а какое меньше

Console.Write ("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.Write ($"Число {num1} больше числа {num2}");
}
else
{
    Console.Write($"Число {num2} больше числа {num1}");
}