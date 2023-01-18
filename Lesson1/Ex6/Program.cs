// на вход принимает число и выдает, является ли число чётным
Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0) 
{
    Console.WriteLine("Число чётное");
}

else
{
    Console.WriteLine("Число нечётное");
}