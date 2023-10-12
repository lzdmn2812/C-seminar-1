// Внутри класса Answer напишите методCompareNumbers, который на вход принимает 
// два числа и выводит, какое число большее, а какое меньшее.

// Console.WriteLine("Введите первое число: ");
//  int firstNumber= Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите второе число: ");
//  int secondNumber= Convert.ToInt32(Console.ReadLine());
//     if (firstNumber==secondNumber)
//     {
//         Console.WriteLine("Введенные числа равны " + firstNumber);
//     }
//     else if (firstNumber>secondNumber)
//         {
//           Console.WriteLine("Второе число " + secondNumber + " меньше чем первое число " + firstNumber);
//         }
//           else
//           {
//             Console.WriteLine("Первое число " + firstNumber + " меньше чем второе число " + secondNumber);
//           }
    
using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
        if (firstNumber==secondNumber)
    {
        Console.WriteLine("Введенные числа равны " + firstNumber);
    }
    else if (firstNumber>secondNumber)
        {
          Console.WriteLine("Второе число " + secondNumber + " меньше чем первое число " + firstNumber);
        }
          else
          {
            Console.WriteLine("Первое число " + firstNumber + " меньше чем второе число " + secondNumber);
          }
    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 5;
            secondNumber = 6;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}