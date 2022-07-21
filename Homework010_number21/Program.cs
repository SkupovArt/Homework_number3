// // 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB = √ (x b — x a) 2 + (y b — y a) 2 + (z b — z a) 


Console.Clear();
Console.WriteLine("Введите координаты точки А: x1 =  ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки А: y1 =  ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки А: z1 =  ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: x2 =  ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: y2 =  ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: z2 =  ");
int z2 = Convert.ToInt32(Console.ReadLine());

//Math.Round(N, 2); округление
// Math.Sqrt(x); квадратный корень
//Math.Pow(x,y); возвести число x в степень y
double Line = Math.Round((Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2))), 2);


Console.WriteLine($"Расстояние между точками = {Line}");