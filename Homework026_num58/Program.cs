// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();

int[,] MatrixRnd(int m, int n, int min, int max)
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

// Сразу признаюсь, самостоятельно решить эту задачу я не смог, т.к. не сумел до конца понять,
// что такое матрицы и как их перемножить именно здесь. Ваша ссылка не помогла( 
//Пришлось обратиться в интернет
// Постараюсь разобраться, что да как, пока понятно слабо

int[,] MatrixMult(int[,] Matrix1, int[,] Matrix2)
{
    if (Matrix1.GetLength(1) != Matrix2.GetLength(0)) Console.WriteLine("Матрицы нельзя перемножить");
    int[,] sum = new int[Matrix1.GetLength(0), Matrix2.GetLength(1)];
    for (int i = 0; i < Matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < Matrix2.GetLength(0); k++)
            {
                sum[i, j] += Matrix1[i, k] * Matrix2[k, j];
            }
        }
    }
    return sum;
}
void Print(int[,] Mat)
{
    Console.WriteLine("Произведение матриц равно:");
    for (int i = 0; i < Mat.GetLength(0); i++)
    {
        for (int j = 0; j < Mat.GetLength(1); j++)
        {
         
            if (j == 0) Console.Write("| ");
            if (j < Mat.GetLength(1) - 1) Console.Write($"{Mat[i, j],3} | ");
            else Console.Write($"{Mat[i, j],3} |");
        }
        Console.WriteLine();
    }
}

int[,] Matrix1 = MatrixRnd(2, 2, 1, 10);
int[,] Matrix2 = MatrixRnd(2, 2, 1, 10);
PrintMatrix(Matrix1);
Console.WriteLine();
PrintMatrix(Matrix2);
Console.WriteLine();
int[,] SumMatrix = MatrixMult(Matrix1, Matrix2);
Print(SumMatrix);