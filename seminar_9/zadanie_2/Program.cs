// Напишите программу, которая будет принимать на 
// вход число и возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    int result=Convert.ToInt32(Console.ReadLine());
    return result;
}

int Sum (int n)
{
    if(n==0)
    {
        return 0;
    }
    
    return Sum(n/10)+n%10;
}

int n=ReadInt("Введите число: ");
Console.WriteLine(Sum(n));