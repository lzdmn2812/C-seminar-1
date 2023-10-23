// Напишите программу, которая принимает на 
// вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int number = int.Parse(numb);
    return number;
}

int Digit = ReadInt("Введите число: ");
int n = 0;
while (Digit>0)
{
    Digit /=10; // d = d / 10 это то же самое что и d /=10
    n++;
}
Console.WriteLine(n);