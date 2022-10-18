//напишите программу,которая выводит 3 цифру заданного числа или сообщае,что третьего числа нет
Console.WriteLine("введите число: ");
int num=int.Parse(Console.Readline()!);
int a1=num/100;
int a2=(num/10)%10;
int a3=num%10;
if ((num/10)%10)
Console.WriteLine($"{num}-> {a3}");
else
Console.WriteLine($"{num}-> третьей цифры нет");

