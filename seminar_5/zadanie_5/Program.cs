// Задача 4: Найдите произведение пар чисел в 
// одномерном массиве. Парой считаем первый и 
// последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GenerateArray(int length)
{
    int[] numbers = new int[length];            // Создаем пустой массив (все элемента = 0)
    Random random = new Random();               // создание генератора случайных чисел
    for (int i = 0; i < numbers.Length; i++)    // заполнение массива случайными числами
    {
        numbers[i] = random.Next(10); // заполнение текущего элемента массива случайным числом в диапазоне [minValue..maxValue]
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

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int [] calculatePare (int [] array)
{
    int [] result = new int[array.Length/2+array.Length%2];
    result[result.Length-1]=array[result.Length-1];
    for (int i = 0; i < array.Length/2; i++)
    {
        result[i] = array[i] * array[array.Length-1-i];
    }
    return result;
}

int lenght = ReadInt("Введите число: ");
int [] arr = GenerateArray(lenght);
PrintArray(arr);
PrintArray (calculatePare(arr));
