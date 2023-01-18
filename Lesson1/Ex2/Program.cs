// На вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число A ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine("Первое число " + numberA + " больше, чем второе число " + numberB);
}

else
{
    Console.WriteLine("Второе число " + numberB + " больше, чем первое число " + numberA);
}