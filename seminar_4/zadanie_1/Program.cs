// Напишите программу, которая принимает на вход 
// число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Prompt (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int sum = 0;
int number = Prompt("Введите число для подсчета сумы: ");
while (number > 0)
{
    sum = sum + number;
    number = number--;
}
Console.Write($"Сумма от 1 до заданного числа равна: {sum}");