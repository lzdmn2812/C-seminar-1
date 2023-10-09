// напишите программу вычисления модуля числа

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number<0)
{
    number= number * -1;
    Console.WriteLine("модуль вашего числа: " + number);
}
else 
{
    Console.Write("модуль вашего числа: " + number);
}