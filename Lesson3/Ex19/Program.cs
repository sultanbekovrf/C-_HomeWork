// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число: ");
int number  = Convert.ToInt32(Console.ReadLine());



if (number <= 10000 || number >= 99999) 
{
    Console.WriteLine("Введенное число не пятизначное, введите другое число: ");
}
else
{
    int A = number / 10000; 
    int B = number / 1000 % 10;
    int C = number / 10 % 10;
    int D = number % 10;
    if ( A > D || A < D || B > C || B < C ) Console.WriteLine("Введенное число не является палиндромом");
    if ( A ==D || D ==C ) Console.WriteLine("Введенное число является палиндромом");
}