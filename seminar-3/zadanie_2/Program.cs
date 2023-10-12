// Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y).

int readQuarter (string message) // Ввод переменных.
{ 
    System.Console.WriteLine(message); // Получаем данные из строки.
    string value = Console.ReadLine(); // Вызов консольного ввода, value - значение, которое вводим.
    return int.Parse(value); // возрвращаем переменную в int.
}
int quarter = readQuarter("Введите номер четверти: ");

if (quarter>0 && quarter<5)
{
    switch(quarter){
        case 1: Console.WriteLine("X > 0, Y > 0"); break;
        case 2: Console.WriteLine("X < 0, Y > 0"); break;
        case 3: Console.WriteLine("X < 0, Y <0"); break;
        default: Console.WriteLine("X > 0, Y < 0"); break;
    }
    
}
else Console.WriteLine("Такой четверти не существует");