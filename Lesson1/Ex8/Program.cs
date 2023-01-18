// на вход число N, на выходе показать все четные числа от 1 до N
Console.WriteLine("Введите натуральное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.WriteLine("Четные числа от 1 до " + a + ":");
while (i <= a)
{
   if (i % 2 == 0)
   {
          Console.Write(i + " ");
   }
   i++;
}