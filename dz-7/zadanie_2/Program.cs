// 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое 
// каждого столбца: 4,6; 5,6; 3,6; 3.
// */
int ReadInt(string message)
{
    Console.WriteLine(message);
    int result=Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GetRandom2DArray(int start, int end, int row, int column)
{
    int[,] matrix = new int[row,column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]=new Random().Next(start,end+1);
        }
    }
    return matrix;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
    
}


double[] GetAVGInArray(int[,] array)
{
    double[] massive= new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)  // i = столбец
    {
        double sum=0;
        for (int j = 0; j < array.GetLength(0); j++) // j = строка
        {
            sum= sum+array[j,i];   // важен порядок [строка (j), столбец (i)]
        }
        massive[i] = sum/array.GetLength(0);
    }
    return massive;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]:f2}\t");
    }
    Console.WriteLine();
}

int userArrayRow = ReadInt("Введите количество строк:");
int userArrayColumn = ReadInt("Введите количество столбцов:");
int userArrayStart = ReadInt("Введите начало диапазона:");
int userArrayEnd = ReadInt("Введите конец диапазона:");
int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);

Print2DArray(user2DArray);
System.Console.WriteLine();
double[] resultArray = GetAVGInArray(user2DArray);
PrintArray(resultArray);