// // Напишите программу, 
// которая на вход принимает
//  позиции элемента в двумерном 
//  массиве, и возвращает значение 
//  этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

Write("Введите номер столбца ");
int a = int.Parse(ReadLine());
Write("Введите номер строки ");
int b = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine($"Точка = {GetFindEl(array)}");

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

int GetFindEl(int[,] array)
{
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
        {
          if (a>array.GetLength(0) || b>array.GetLength(1))
           {
            Console.WriteLine("Такого числа нет");}
            else break; //{Console.WriteLine($"{array[a-1,b-1]}");}
        }
  }
  return array[a-1,b-1];
}     

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}