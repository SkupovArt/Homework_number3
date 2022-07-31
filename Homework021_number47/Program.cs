// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

//вы подсказали на 5 занятии, как получить тип double valueDoubleRnd = new Random().NextDouble() * (max - min) + min;

Console.Clear();
double[,] NewMatrixRnd(int m, int n, int min, int max)
{
    double[,] arr = new double[m, n];
    //double rnd = new Random().NextDouble();
    for (int i = 0; i < arr.GetLength(0); i++) 
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(new Random().NextDouble()* (max - min) + min, 1);
        }
    }
    return arr;
}

void PrintMatrix(double[,] arr)
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
double[,] arrayresult = NewMatrixRnd(5, 5, 1, 10);
PrintMatrix(arrayresult);