//задача 10->напишите программу,которая принимает на вход трехзначное число и на выходе показывает 2 цифру этого числа
Console.WriteLine("введите 3-значное число: ");
int num=int.Parse(Console.Readline()!);
int a1=num/100;
int a2=(num/10)%10;
int a3=num%10;
Console.Write($"число {num} ->{a2}");