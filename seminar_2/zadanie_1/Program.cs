// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
int ReadInt(string msg) // объявляет фунцию ридинт и строковый параметр мсг
{

    Console.WriteLine(msg); //  пишет в консоль  параметр мсг
    string numb = Console.ReadLine(); // считывает с консоли строки
    int number; // ввели переменную
    number = int.Parse(numb); //  преобразовали строки в числа
    return number; //  возврат из функции
    }
int number= ReadInt("Введите треххзначное число"); // вызываем функцию РидИнт и передаем в эту функцию функцию текст, результат складываем  
if (number > 99 && number < 1000)
{
    int LastDigit = number % 10; //  вводим переменную "Последнее число"
    Console.WriteLine("LastDigit=" + LastDigit);
}
else Console.WriteLine("LastDigit not three digit");
