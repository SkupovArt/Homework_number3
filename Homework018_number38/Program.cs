// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();

int[] Massive(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 9);

    }
    return arr;
}

int[] MaxMinarg(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
        if (min > arr[i]) min = arr[i];
     
    }
    return new int[] {max, min};
}




void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + "]");
    }
}

void PrintSub(int[] res)
{

    Console.WriteLine();
    Console.Write($"Разница максимального и минимальных значений = ");
    Console.WriteLine(res[0] - res[1]);

}




int[] num = Massive(5);
PrintArr(num);
PrintSub(num);