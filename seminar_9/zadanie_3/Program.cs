// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


int ReadInt(string msg)
{
    Console.WriteLine(msg);
    int result=Convert.ToInt32(Console.ReadLine());
    return result;
}

int Power(int a, int b)
{
    if (b==0)
    {
        return 1;
    }
    return Power(a, b-1)*a;
}

int a=ReadInt("Введите число: ");
int b=ReadInt("Введите степень: ");
Console.WriteLine(Power(a,b));