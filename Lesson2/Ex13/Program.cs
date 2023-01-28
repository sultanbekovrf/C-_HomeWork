// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.Write("Введите любое число, больше 99 : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.Write("Третьей цифры нет, введите число больше 99: ");
}
else
{
    while (number >= 1000)
    {
        number = number / 10;
    }
        Console.WriteLine("Третья цифра: " + number % 10);
}
