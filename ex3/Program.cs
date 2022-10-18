//напишите программу,которая принимает на вход число и выводит кратно ли оно на 7 и 23 одновременно
Console.Write("введите число: ");
int num=int.Parse(Console.Readline()!);
if (num/7 && num/23)
Console.WriteLine($"{num}-> да");
else
Console.WriteLine($"{num}-> нет");

