﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//Долго бодался с этой задачей, в итоге пришел к мнению, что проще отразить введенное слово 
// или число и сравнить исходник с ревесом
// Но возникли проблемы с созданием реверса, забыл как это делать. 
//Решение создания реверса числа одолжил из интернета, каюсь. Честно говоря, понял плохо, как это работает.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num;
string rev = num.ToString();
char[] ar = rev.ToCharArray();
Array.Reverse(ar);
rev = new String(ar);
num = Convert.ToInt32(rev);
if(num == num1) Console.WriteLine("Ваше число палиндром");
else Console.WriteLine("ваше число не палиндром");

