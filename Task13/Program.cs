// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

if (n < 100)
  {
    Console.WriteLine("Третьего числа нет");
   }

else if (n > 99 && n < 1000)
{
    int n3 = n % 10;
    Console.WriteLine($"Третье число: {n3}");
}

else if (n > 999 && n < 10000)
{
    int n1 = n / 10;
    int n3 = n1 % 10;
    Console.WriteLine($"Третье число: {n3}");
}

else if (n > 10000 && n < 100000)
{
    int n1 = n / 100;
    int n3 = n1 % 10;
    Console.WriteLine($"Третье число: {n3}");
}

// НАШЕЛ ТАКОЕ РЕШЕНИЕ В ИНТЕРНЕТЕ:

//Console.Clear();
//Console.WriteLine("Введите число: ");
//int n = int.Parse(Console.ReadLine());
//string num = Convert.ToString(n);
//int numStr = num.Length;

//if (numStr > 2)
//  Console.WriteLine($"Третья цифра: {num[2]}");
//else
//  Console.WriteLine("Третьей цифры нет");