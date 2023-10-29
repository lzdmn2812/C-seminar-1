// Задача 4: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] numbers = new int[length];            // Создаем пустой массив (все элемента = 0)
    Random random = new Random();               // создание генератора случайных чисел
    for (int i = 0; i < numbers.Length; i++)    // заполнение массива случайными числами
    {
        numbers[i] = random.Next(minValue, maxValue + 1); // заполнение текущего элемента массива случайным числом в диапазоне [minValue..maxValue]
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


int [] CopyArray (int [] Array)
{
    int [] NewArray = new int [Array.Length];
    for (int i = 0; i < Array.Length; i++)
    {
        NewArray[i]=Array[i];

    } 
    return NewArray;
}

int [] array1 = GenerateArray (10, 0, 10);
PrintArray(array1);

int [] array2 = array1;

array1[0]= 100;
PrintArray(array2);

int [] array3 = CopyArray(array1);
array1[1]=150;
array1[0]= 0;
Console.WriteLine();
PrintArray(array1);
PrintArray(array2);
PrintArray(array3);
