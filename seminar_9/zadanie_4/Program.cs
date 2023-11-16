// Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    int result=Convert.ToInt32(Console.ReadLine());
    return result;
}

bool Power2(int a)
{
    if(a==1)
    {
        return true;
    }
    return a%2==0 && Power2(a/2);
}

int a=ReadInt("Введите число: ");
Console.WriteLine(Power2(a));
