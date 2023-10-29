// Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int ReadInt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int [] binaryArray (int number)
{
    int[] binary = new int[8];
    for (int i = binary.Length-1; i >=0 ; i--)
    {
        binary[i]=number%2;
        number= number/2;

    }
    return binary;
}

void PrintArray(int[] array)
{
    System.Console.Write(array[0]);             // Вывод 1-го элемента массива
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]}");  // Вывод текущего элемента массива
    }
    System.Console.WriteLine();                 // Перевод строки (чтобы отделять массивы)
}

int number = ReadInt("Введите число: ");
PrintArray (binaryArray(number));
