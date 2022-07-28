// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();

int[] Massive(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);

    }
    return arr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}



void Search(int[] arr)
{
    int j = 0;
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) j += 1;   
        
    }
   Console.WriteLine($" - {j}");
}

int[] mas = Massive(5);
PrintArr(mas);
Search(mas);