﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ack(int n, int m)
{
    if (n==0)
    {
        return m+1;
    }
    else if(m==0)
    {
        return ack(n-1,1);
    }
    return ack(n-1, ack(n,m-1));
}

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    int result=Convert.ToInt32(Console.ReadLine());
    return result;
}

int n=ReadInt("Введите число N: ");
if (n==4)
{
    Console.WriteLine("Что бы вы не выбрали дальше, ваш компьютер не выдержит. Если хотите продолжить нажмите любую кнопку:) ");
    Console.ReadKey();
    Console.WriteLine();
}

int m=ReadInt("Введите число M: ");

Console.WriteLine(ack(n,m));