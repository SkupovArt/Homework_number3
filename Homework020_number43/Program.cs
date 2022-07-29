// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите координату точки b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки k2: ");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки k2: ");
int k2 = int.Parse(Console.ReadLine());

void Position(int a, int b, int c, int d)
{
    double x = 0;
    double y1 = 0;
    double y2 = 0;
    x = (c - a)/(b - d);
    y1 = Math.Round(b * x + a, 1);
    y2 = Math.Round(d * x + c, 1);
    Console.WriteLine($"Точка пересечения прямых => {y1} и {y2}");
}

Position(b1, k1, b2, k2);