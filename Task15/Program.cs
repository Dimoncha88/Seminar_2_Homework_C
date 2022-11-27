// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день 
//недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите число от 1 до 7");
int n = int.Parse(Console.ReadLine());

if(n == 0 || n > 7) 
    Console.WriteLine("Введено неверное число");
else
Console.Write(n < 6 ? $"Не выходной - " : $"Выходной - ");

if (n == 1) Console.WriteLine("Понедельник");
if (n == 2) Console.WriteLine("Вторник");
if (n == 3) Console.WriteLine("Среда");
if (n == 4) Console.WriteLine("Четверг");
if (n == 5) Console.WriteLine("Пятница");
if (n == 6) Console.WriteLine("Суббота");
if (n == 7) Console.WriteLine("Воскресенье");