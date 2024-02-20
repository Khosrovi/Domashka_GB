//ДОМАШНЕЕ ЗАДАНИЕ ПО ДВУМЕРНЫМ МАССИВАМ.

// 1. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] array = new int[3,4];

// void CreateArray()
// {
//     for(int i = 0; i<array.GetLength(0); i++)
//     {
//         for(int j = 0; j<array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }

// }

// void PrintArray()
// {
//     for(int i = 0; i<array.GetLength(0); i++)
//     {
//         for(int j = 0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();

// }

// CreateArray();
// PrintArray();

// Console.WriteLine("Введите номер строки");
// int row = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите номер столбца");
// int column = Convert.ToInt32(Console.ReadLine());

// int element = GetElement(array, row, column);
// if(element !=-1)
// {
//     Console.WriteLine("Элемент:" + element);
// }
// else
// {
//     Console.WriteLine("Такого элемента не существует");

// }

// static int GetElement(int[,] array, int row, int column)
// {
//     int rows = array.GetLength(0);
//     int columns = array.GetLength(1);

//     if(row >=0 && row < rows && column >=0 && column < columns)
//     {
//         return array[row, column];
//     }
//     else 
//     {
//         return-1;
//     }
// }

// 2. Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// int[,] array = new int[3,4];

// void CreateArray()
// {
//     for(int i = 0; i<array.GetLength(0); i++)
//     {
//         for(int j = 0; j<array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }

// }

// void PrintArray()
// {
//     for(int i = 0; i<array.GetLength(0); i++)
//     {
//         for(int j = 0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();

// }

// CreateArray();
// PrintArray();

// for(int j = 0; j<array.GetLength(1); j++)
// {
//     int temp = array[0, j];
//     array[0, j] = array[2, j];
//     array[2, j] = temp;
// }
// Console.WriteLine("Массив после обмена строк: ");
// for(int i = 0; i<array.GetLength(0); i++)
// {
//     for(int j = 0; j<array.GetLength(1); j++)
//     {
//         Console.Write(array[i,j]+ " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// 3. Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] array = new int[8,4];


// void CreateArray()
// {
//     for(int i = 0; i<array.GetLength(0); i++)
//     {
//         for(int j = 0; j<array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }

// }

// void PrintArray()
// {
//     for(int i = 0; i<array.GetLength(0); i++)
//     {
//         for(int j = 0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();

// }

// CreateArray();
// PrintArray();

// int minSumRowIndex = 0;
// int minSum = int.MaxValue;
// for(int i = 0; i<array.GetLength(0); i++)
// {
//     int rowSum =0;
//     for(int j = 0; j<array.GetLength(1); j++)
//     {
//         rowSum += array[i, j];
//     }
//     if(rowSum < minSum)
//     {
//         minSum = rowSum;
//         minSumRowIndex = i;
//     }
// }
// Console.WriteLine($"\nСтрока с наименьшей суммой элементов (строка {minSumRowIndex + 1}):");
// for(int j = 0; j<array.GetLength(1); j++)
// {
//     Console.Write(array[minSumRowIndex, j] + " ");
// }
