// Задача 1: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

int enterInteger(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool checkTriangle(int a, int b, int c)
{
    if (a < (b+c) && b < (a+c) && c < (b+a))
    {
        return true;
    }
    else
    {
        return false;
    }
}

int a = enterInteger("Введите длину первой стороны треугольника: ");
int b = enterInteger("Введите длину второй стороны треугольника: ");
int c = enterInteger("Введите длину третьей стороны треугольника: ");

Console.WriteLine(checkTriangle(a, b, c) ? "Такой тругольник существует" : "Такой треугольник не существует!");