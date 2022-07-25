// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов, 
// // заполненный псевдослучайными числами и выводит их на экран.

// // 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
Console.WriteLine("Введите длину массива");
int number = int.Parse(Console.ReadLine());
 

int[] Random(int number)
{
    int[] array = new int[number];
    int i = 0;
    while (i < array.Length)
    {
        array[i] = new Random().Next(0, 99); 
        i++;
    }
    return array;
}

void Print(int[] array)
{
    
    int i = 0;
    Console.Write("[");
    while (i < array.Length)
    {
        Console.Write($"{array[i]}, ");
        i++;
    }
    Console.Write("]");
}
int[] hernya = Random(number);
Print(hernya);
