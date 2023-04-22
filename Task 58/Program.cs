/*Задача 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int GetNumber (string argument)
{
  System.Console.WriteLine($"Введите {argument}: ");
  return int.Parse(Console.ReadLine());
}

int a = GetNumber("количество строк в первом массиве");
int b = GetNumber("количесвто столбцов в первом массиве");
int c = GetNumber("количесвто столбцов во втором массиве");
int d = GetNumber("количесвто столбцов во втором массиве");
Console.WriteLine();

int[,] firstArray = CreateArray(a,b);
Console.WriteLine("Первый массив");
PrintArray(firstArray);
Console.WriteLine();

int [,] secondArray = CreateArray(c,d);
Console.WriteLine("Второй массив");
PrintArray(secondArray);
Console.WriteLine();

int[,] CreateArray(int m,int n)
{
  int[,] array = new int [m,n];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j] = new Random().Next (0, 10);
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

int[,] multipliedArray = CreateArray(a,d);

void MultiArray(int[,] firstArray, int[,] secomdArray, int[,] multipliedArray)
{
  for (int i = 0; i < multipliedArray.GetLength(0); i++)
  {
    for (int j = 0; j < multipliedArray.GetLength(1); j++)
    {
      int thirdArray = 0;
      for (int k = 0; k < firstArray.GetLength(1); k++)
      {
        thirdArray += firstArray[i,k] * secondArray[k,j];
      }
      multipliedArray[i,j] = thirdArray;
    }
  }
}

MultiArray(firstArray, secondArray, multipliedArray);
Console.WriteLine($"Произведение двух массивов равно:");
PrintArray(multipliedArray);
