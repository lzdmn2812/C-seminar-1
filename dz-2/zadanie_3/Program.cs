//  Напишите программу, которая принимает на вход цифру, 
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

string [] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
if (number >=1 && number <=7)
{
    Console.Write(days[number-1]);
    if (number-1 == 5 || number-1 == 6)
    {
        Console.Write(" - выходной.");
    }
    else
    {
        Console.Write(" - будний.");
    }
}
else 
{
    Console.WriteLine("Такого дня недели не существует.");
}