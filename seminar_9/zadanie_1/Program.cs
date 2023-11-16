// Задайте значения M и N. Напишите программу, которая 
// рекурсивно выведет все натуральные числа в промежутке 
// от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    int result=Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintNaturalNumbers(int m, int n)
{
    if (m<n)
    {
        return;
    }
    PrintNaturalNumbers(m, n-1);
    System.Console.WriteLine($"{n}\t");
}

int m=ReadInt("Введите первое число: ");
int n=ReadInt("Введите второе число: ");
System.Console.WriteLine(PrintNaturalNumbers(m, n));