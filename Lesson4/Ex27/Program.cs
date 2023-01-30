// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе

// // 1. Ввод числа 
int GetNumberByUser(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

// 2. Получение суммы чисел
int SumOfNumbers(int countByUser)
{
  int result = 0;
    while (countByUser > 0)
    {
      result += countByUser % 10;
      countByUser /= 10;
    }
    return result;
  } 
  
int countByUser = GetNumberByUser("Введите число: ");
int sum = SumOfNumbers(countByUser);
Console.WriteLine("Сумма цифр числа равна " + sum);