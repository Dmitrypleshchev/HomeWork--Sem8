/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

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

int minSum = 1;
int sum = SumInLine(numbers,0);
for (int i = 1; i < numbers.GetLength(0); i++)
{
  if (sum > SumInLine(numbers, i))
  {
    sum = SumInLine(numbers, i);
    minSum +=i;
  }
}

int SumInLine (int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  { 
    sum += array[i,j];
  }
  return sum;
}
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов массива {minSum}");

