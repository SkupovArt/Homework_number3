// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в
//  каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Clear();

int[,] NewMatrixRnd(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("| ");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} | ");
            else Console.Write($"{arr[i, j],3} |");
        }
        Console.WriteLine();
    }
}


void SumString(int[,] arr)
{
    int sumMin = 0;
    int indexMin = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
            if (sumMin > sum) indexMin = j;
        }
          
        sumMin = sum;     
    }
    Console.WriteLine($"Строка с минимальной суммой элементов = {indexMin + 1}");
}

int[,] array = NewMatrixRnd(4, 4, 1, 10);
PrintMatrix(array);
Console.WriteLine();
SumString(array);