// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Clear();
Console.WriteLine("Введите индексы позиций в массиве:");
Console.Write("Индекс I = ");
int IndexI = int.Parse(Console.ReadLine());
Console.Write("Индекс I = ");
int IndexJ = int.Parse(Console.ReadLine());

int[,] MatrixNew(int m, int n, int min, int max)
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
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j], 3} | ");
            else Console.Write($"{arr[i, j], 3}  |");
        }
        Console.WriteLine();
    }
}

void SearchIndex(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == IndexI && j == IndexJ) Console.WriteLine($"Значение с индесом {IndexI},{IndexJ} = {arr[i, j]}");
            else Console.WriteLine("Такого индекса нет");
        }
        Console.WriteLine();
    }
}



int[,] array = MatrixNew(5, 5, 1, 10);

PrintMatrix(array);
Console.WriteLine();
SearchIndex(array);