// Console.WriteLine("Введите по очереди три числа: ");
// int a= Convert.ToInt32(Console.ReadLine());
// int b= Convert.ToInt32(Console.ReadLine());
// int c= Convert.ToInt32(Console.ReadLine());

// if (a==b && b==c)
// {
//     Console.WriteLine("Введенные числа равны");
// }
//  if (a>b && a>c)
// {
//     Console.WriteLine($"Максимальное число {a}");
// }
//  if (b>a&& b>c)
// {
//     Console.WriteLine($"Максимальное число {b}");
// }
//  if (c>a && c>b)
// {
//     Console.WriteLine($"Максимальное число {c}");
// }

using System;

public class Answer {
    
  static int FindMax(int a, int b, int c) {
    int f = 0;
      if (a==b && b==c)
{
    f = a;
}
 if (a>b && a>c)
{
f = a;
   }
 if (b>a && b>c)
{
    f = b;
}
 if (c>a && c>b)
{
    f = c;
}
    return f;
}

  // Не удаляйте и не меняйте метод Main! 
  static public void Main(string[] args) {
        int a, b, c;

        if (args.Length >= 3) {
           a = int.Parse(args[0]);
           b = int.Parse(args[1]);
           c = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           a = 5;
           b = 5;
           c = 5;
        }

        // Не удаляйте строки ниже
        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}