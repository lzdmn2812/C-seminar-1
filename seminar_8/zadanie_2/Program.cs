// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, 
// если это невозможно, программа должна вывести сообщение для пользователя.

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    int result=Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] CreateMatrix(int row, int column)
{
    int[,] matrix= new int[row,column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i,j]= new Random().Next(1,10);
        }
    }
    return matrix;
}

int[,] ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i+1; j < matrix.GetLength(1); j++)
        {
            int temp=matrix[i,j];
            matrix[i,j]=matrix[j,i];
            matrix[j,i]=temp;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}




int row=ReadInt("Введите количество строк: ");
int column=ReadInt("Введите количество столбцов: ");
if (row!= column)
{
    Console.WriteLine("Невозможно перевернуть матрицу");
}
else
{
    int[,] matrix=CreateMatrix(row,column);
    PrintMatrix(matrix);
    Console.WriteLine();
    PrintMatrix(ChangeMatrix(matrix));
}