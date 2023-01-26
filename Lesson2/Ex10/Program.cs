// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999) 
{
    Console.WriteLine("Введенное число не является трехзначным, попробуйте еще раз");
}
else
{
    Console.WriteLine("Вторая цифра: " + number / 10 % 10);
} 