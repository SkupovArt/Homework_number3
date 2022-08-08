//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1 
// 9 5 3 2
// 8 4 4 2

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

// i - столбцы

int[,] NewMatrix(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int k = 0; k < arr.GetLength(1) - 1; k++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                int max = arr[0, 0];
                if (arr[i, j] < arr[i, j + 1])
                {
                    max = arr[i, j + 1];
                    arr[i, j + 1] = arr[i, j];
                    arr[i, j] = max;
                }
            }
        }
    }
    return arr;
}

// Очень долго парился с этой задачей в поисках красивого решения, по итогу сделал просто рабочее. 
// но если подскажите, как можно сделать эффективнее, буду рад

int[,] array = NewMatrixRnd(4, 4, 1, 10);
PrintMatrix(array);
Console.WriteLine();
int[,] newArray = NewMatrix(array);
PrintMatrix(newArray);
