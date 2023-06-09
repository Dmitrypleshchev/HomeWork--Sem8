﻿/* Задача 60.Сформируйте трёхмерный массив из случайных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int GetNumber (string argument)
{
  System.Console.WriteLine($"Введите {argument}: ");
  return int.Parse(Console.ReadLine());
}

int a = GetNumber("количество элементов на первой оси");
int b = GetNumber("количесвто элементов на второй оси");
int c = GetNumber("количество элементов на третьей оси");

int [,,] CreateArray(int a, int b, int c)
{
  int[,,] array = new int [a,b,c];
  for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
          array[i, j, k] = new Random().Next(0,10);
        }
    }
}
  return array;
}

void PrintArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for(int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write($"[{i},{j},{k}] {array[i,j,k]}; ");
      }
    Console.WriteLine();
    }
  }
}

int[,,] numbers = CreateArray(a,b,c);
PrintArray(numbers); 

