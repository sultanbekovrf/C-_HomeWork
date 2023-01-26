// на вход число N, на выходе показать все четные числа от 1 до N
Console.WriteLine("Введите натуральное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 2;
Console.WriteLine("Четные числа от 1 до " + a + ":");
while (i <= a)
{
   Console.Write(i + " ");
   i = i + 2;
}