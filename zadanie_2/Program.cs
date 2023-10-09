//На вход принимаем два числа, проверяем является ли второе число квадратом первого

Console.WriteLine("введите первое число: ");
int number1= int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
 
if (number2==number1*number1)
Console.WriteLine("yes");
else Console.WriteLine("no");
