// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//Console.Clear();
Console.WriteLine("Введите число:  ");
int num = Convert.ToInt32(Console.ReadLine());
int[] pal = {(int)num};
void Palindrome(int[] pal)
{
    int count = pal.Length;

    for (int i = 0; i < count/2; i++)
    {
       for (int j = count; j > i; j--)
       {
            if (i == j) Console.WriteLine("Ваше число палиндром");
           else  Console.WriteLine("ваше число не палиндром");
    
       }
    }
}

Palindrome(pal);