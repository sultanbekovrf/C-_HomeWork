// Принимает на вход три числа и выдает максимальное
Console.WriteLine("Введите число A ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число C ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine("max = " + max);