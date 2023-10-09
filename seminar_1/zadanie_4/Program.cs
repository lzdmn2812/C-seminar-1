//написать программу, которая на вход принимает 1 число N,
// а на выходе показывает все целые числа в промежутке от -N до N

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// string Input = Console.ReadLine();  - считывание и сохранение в переменную строки
// int number = Convert.ToInt32(Input);  - конвертация в целое число (32 бита) и сохранение числовой переменной

if (number<=0)
{
    Console.WriteLine("Введите положительное число");
}
else
{
    int I = -1 * number;
    while (I <= number)
    {
        Console.Write(I + " ");
        I++; // увеличение i на 1
    }
}
