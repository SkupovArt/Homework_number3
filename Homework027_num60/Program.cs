// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// Подглядел решение у коллег, но возникли проблемы с проверкой на уникальность рандомного числа. 
// Есть идея создать отдельный метод для проверки, что крайне сложно
// А можно отойти от рандома и вбить все вручную
// ну или использовать отдельный массив как жертву чисел и после их использования сразу же их удалять

int[] Massive(int min, int max) //создаю жервенный массив, из которго буду брать неповторяющиеся числа
{
    int[] mass = new int[15];
    for (int i = 0; i < mass.Length -1; i++)
    {
        mass[i] = i + 1;
    }
    return mass;
}

void PrintMassive(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i]);
    }
    Console.WriteLine();
}

int[,,] MatrixRnd(int m, int n, int l, int[] mas) //данный метод берет из заданного массива число и после его удаляет
                                                  //насколько правильно написано, оценить не могу, но вроде работает
{
    int[,,] arr = new int[m, n, l];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {

                int h = rnd.Next(0, 9);
                arr[i, j, k] = mas[h];
                mas = mas.Where(e => e != mas[h]).ToArray(); // как удалить число из первого массива придумать не смог, подглядел
            }

        }
    }
    return arr;
}

// а тут мне пришла в голову "гениальная" идея сравнить два массива на наличие одинаковых чисел... 
//Ага, думаю я после того, как что-то сделаю =)
// int[,,] DelReplay(int[,,] arr, int[,,] arrCopy)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int i1 = 0; i1 < arrCopy.GetLength(0); i1++)
//         {
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 for (int j1 = 0; j1 < arrCopy.GetLength(1); j1++)
//                 {
//                     for (int k = 0; k < arr.GetLength(2); k++)
//                     {
//                         for (int k1 = 0; k1 < arrCopy.GetLength(2); k1++)
//                         {

//                             if (arr[i, j, k] == arrCopy[i1, j1, k1]) arr[i, j, k] = rnd.Next(10, 99);
//                         }
//                     }
//                 }
//             }
//         }

//     }
//     return arr;
// }

// здесь  я думал, как подставлять числа без использования рандома, но вовремя понял, что так не сработает
// int[,,] MatrixRnd(int m, int n, int l, int min, int max)
// {
//     int[] massive = { 1, 2, 3, 4, 5, 6, 7, 8 };
//     int[,,] arr = new int[m, n, l];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 arr[i, j, k] = massive[i]; // от балды написал, чтобы числа были разные 
//             }

//         }
//     }
//     return arr;
// }


void Print(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
    }
}

int[] mass = Massive(0, 99);
PrintMassive(mass);
Console.WriteLine();
int[,,] WTF = MatrixRnd(2, 2, 2, mass);
Print(WTF);

