//напишите программу ,которая выводит случайное число из отрезка[10,99]
// и выводит максимальное из 2
int num=new Random().Next(10,100);
int a1= num /10;
int a2=num%10;
int max=a1;
if (max<a2)
a2=max;
Console.WriteLine($"Максимальное число в цифре {num} {max}");


