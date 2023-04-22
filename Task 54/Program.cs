/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int GetNumber (string argument)
{
  System.Console.WriteLine($"Введите {argument}: ");
  return int.Parse(Console.ReadLine());
}

int m = GetNumber("количество строк в массиве");
int n = GetNumber("количесвто столбцов массиве");

int [,] CreateArray(int m, int n)
{
  int[,] array = new int [m,n];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j] = new Random().Next (-100, 100);
    }
  }
  return array;
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
      
    }
    Console.WriteLine();
  }
}

int[,] numbers = CreateArray(m,n);
PrintArray(numbers);

void SortNumbers (int[,] array)
{
  for(int i = 0; i < array.GetLength(0); i++)
  {
   for (int j = 0; j < array.GetLength(1); j++)
   {
    for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
          {
            int temp = array[i, k + 1];
            array[i, k + 1] = array[i, k];
            array[i, k] = temp;
          }
      }
    }
  }
}

Console.WriteLine();
SortNumbers(numbers);
PrintArray(numbers);
