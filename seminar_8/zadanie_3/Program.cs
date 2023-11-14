// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 
// Значения элементов массива 0..9

int[] CreateArray (Length)
{
    int[] array= new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(0,10);
    }
return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}

int CountFrequency (int[] array)
{
    int[] FrequencyArray= new int[10];
    for (int i = 0; i < array.Length; i++)
    
        {
            FrequencyArray[array[i]]++;
        }
    return FrequencyArray;
}

int[] array = CreateArray(20);
PrintArray(array);
int[] NewArray = FrequencyArray(array);
PrintArray(NewArray);
