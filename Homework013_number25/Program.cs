// 25. Напишите цикл, который принимает на вход два числа А и В, и возводит число А
// в натуральную степень в
// 3, 5 -> 243(3 в 5 степени)


Console.Clear();
Console.WriteLine("Введите возводимое число");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень возведения");
int B = int.Parse(Console.ReadLine());

// Здесь решил через обычный цикл, без заморочек, хотя ощущение лишнего есть.

// int res = 1;
// for(int i = 0; i < B; i++) //если сделать i <= B, то на выходе число на степень больше, чем нужно
// {
//     res= res*A;
// }
//Console.WriteLine(res);



// Здесь я пытаюлся решить через метод, но вышло тоже сомнительно .

void Stepa(int num1, int num2)
{
    int i = 0;
    int res = 1;
    while (i < B)
    {
        res = res * A;
        i++;
    }
    Console.WriteLine($"Число {A} в степени числа {B} = {res} ");
}

Stepa(A, B);