﻿//Программа, которая выдает день недели по заданному номеру
Console.Write("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());
string []days = {"Понеделник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
if (number>=1&&number<=7)
{
    Console.Write(days[number-1]);
}
else Console.Write("Дня недели не существует");
// if (number==1)
// {
//     Console.Write("Понедельник ");
// }
// else if (number==2)
// {
//     Console.Write("Вторник ");
// }
// else if (number==3)
// {
//     Console.Write("Среда ");
// }
// else if (number==4)
// {
//     Console.Write("Четверг ");
// }
// else if (number==5)
// {
//     Console.Write("Пятница ");
// }
// else if (number==6)
// {
//     Console.Write("Суббота ");
// }
// else if (number==7)
// {
//     Console.Write("Воскресенье ");
// }
// else 
// {
//     Console.Write("Вы ввели число меньше 1 или больше 7");
// }
// //можно убрать везде else, но сделать в конце проверку "если число меньше 0 и больше 7"