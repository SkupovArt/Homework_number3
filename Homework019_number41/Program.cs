// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Введите объем числа");
int num = int.Parse(Console.ReadLine());


int[] Number(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine("Введите число: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}
void Counter(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) counter += 1;
    }
    Console.Write($"Количество положительных чисел - {counter}");
}
int[] res = Number(num);
Counter(res);