using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже
  if (number<2)
        {
        Console.WriteLine("Вы ввели слишком маленькое число");
        } 
    int even=0;  
    int rem=number%2;
    if (rem==0)
    {
        while (even<number)
        {
        even = even+2;
        Console.Write(even+"    ");
        }
    }
    else 
    {
        while (even<number-1)
        {
            even = even+2;
            Console.Write(even+"    ");
        }
    }

    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 7;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}