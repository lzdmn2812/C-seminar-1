// Задача 1: Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int ArrayChange (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = array[i]* -1;
    }
    return array;
}

int [] arr = GenerateArray(12, -9, 9);
PrintArray(arr);
PrintArray(ArrayChange(arr));
_______________________________________________________

/*Задача 1: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

int[] GenerateArray(int lenght, int minValue, int maxValue)
{

    int[] numbers = new int[lenght];
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(minValue, maxValue + 1);
    }
    return numbers;
}

void PrintArray(int[] array)
{
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {

        System.Console.Write($", {array[i]}");
    }
    System.Console.WriteLine();
}

int[] ArraChanging(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i]= array[i]*-1;
    }
    return array;

}

int[] arr = GenerateArray(12, -9, 9);
PrintArray(arr);
PrintArray (ArraChanging(arr));