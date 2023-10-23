// Напишите программу, которая принимает на 
// вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int number = int.Parse(numb);
    return number;
}
int searchFactorial(int number)
{
    int i = 1;
    int result = 1;
    while (i<=number)
    {
        result *= i;
        i++;
    }
    return result;
}
int number = ReadInt("Введите число: ");
Console.WriteLine(searchFactorial(number));