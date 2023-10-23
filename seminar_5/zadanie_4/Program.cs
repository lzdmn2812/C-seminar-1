﻿// Задача 3: Задайте одномерный массив из 10 случайных 
// чисел в диапазоне от 1 до 200. Найдите количество  
// двузначных элементов массива. 
// Пример для массива из 5, а не 10 элементов. 
// В своём решении сделайте для 10
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GenerateArray(int length)
{
    int[] numbers = new int[length];            // Создаем пустой массив (все элемента = 0)
    Random random = new Random();               // создание генератора случайных чисел
    for (int i = 0; i < numbers.Length; i++)    // заполнение массива случайными числами
    {
        numbers[i] = random.Next(200); // заполнение текущего элемента массива случайным числом в диапазоне [minValue..maxValue]
    }
    return numbers;
}
// Функция вывода массива на экран
void PrintArray(int[] array)
{
    System.Console.Write(array[0]);             // Вывод 1-го элемента массива
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]}");  // Вывод текущего элемента массива
    }
    System.Console.WriteLine();                 // Перевод строки (чтобы отделять массивы)
}

int CountToDigit(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i]>9 && array[i]<100)
       {
        count++;
       }
    }
    return count;
}
int [] arr = GenerateArray(10);
PrintArray(arr);
Console.WriteLine($"Количество двухзначных элементов {CountToDigit(arr)}");