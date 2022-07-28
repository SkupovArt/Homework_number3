// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
        if (i % 2 != 0) j = j + arr[i];   
        
    }
   Console.WriteLine($"Сумма элементов на нечетных позициях = {j}");
}

int[] mas = Massive(5);
PrintArr(mas);
Search(mas);