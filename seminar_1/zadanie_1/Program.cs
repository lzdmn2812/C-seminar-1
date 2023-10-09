// напишите программу, которая на вход принимает число и выдает его квадрат
// например: 4 -> 16; -3 -> 9;

Console.WriteLine("введите число: ");
int number = int.Parse(Console.ReadLine());
int result = number*number; 
Console.WriteLine($"Квадрат числа {number} равен {result}");

