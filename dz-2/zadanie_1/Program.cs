// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number>99 && number<1000)
{
    number=number/10;
    Console.WriteLine($"Вторая чифра заданного числа: {number%10}");
}
else 
{
    Console.WriteLine("Ошибка. Введите трехзначное число!");
}