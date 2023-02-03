// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии

void PrintNumbers(int N)
{
    if(N==1)
    {
        Console.Write(N);
        return;
    }
    {
        Console.Write($"{N}, ");
        PrintNumbers(N-1);
    }
}


Console.Write("Введите натуральное число: ");
int N = int.Parse(Console.ReadLine());

PrintNumbers(N);