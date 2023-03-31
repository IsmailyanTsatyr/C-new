// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/*

double [,] FillMatrixitRandom(int row ,int column)
{
    double [,] array = new double [row,column];
    Random rnd = new Random(); 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0 ; j < array.GetLength(1); j++)
        {
            array [i,j] = Math.Round(rnd.NextDouble(), 2);
        }
    }
    return array;
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0 ; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t ");
        }
        Console.WriteLine();
    }
}

Console.Write("ВВедите кол-во строк  ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите кол-во столбцов  ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] matrix = FillMatrixitRandom(row,column);
PrintMatrix(matrix);


*/


// Задача 50. Напишите программу, которая на вход принимает позиции элемента
//  в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

/*
int [,] FillMatrixitRandom(int row ,int column)
{
    int [,] array = new int [row,column];
    Random rnd = new Random(); 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0 ; j < array.GetLength(1); j++)
        {
            array [i,j] = rnd.Next(1,99);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0 ; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t ");
        }
        Console.WriteLine();
    }
}


Console.Write("ВВедите кол-во строк  ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите кол-во столбцов  ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixitRandom(row,column);
PrintMatrix(matrix);
Console.Write("Введите строку : ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец : ");
int j = Convert.ToInt32(Console.ReadLine());

if (i > row || j > column)
System.Console.WriteLine("Такого числа нет  ");
else 
{
 Console.WriteLine($"Значение элемента равно {matrix[i-1,j-1]} ");
}
//object c = matrix.GetValue(i-1,j-1);
//Console.WriteLine(c);

*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:

/*

int[,] FillMatrixWithRandom(int row, int column)
{
int[,] array = new int[row, column];
Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = rnd.Next(0, 10);
}
}
return array;
}

void PrintMatrix(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i, j]} \t");
}
Console.WriteLine();
}
}

void SumMainDiagonal(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
        {
        double sum1 = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
            {
            
            if(i <= matrix.GetLength(0))
                {
                sum1+=matrix[i,j];
                
                }
                
            }
            sum1 = sum1 /  matrix.GetLength(1);
            System.Console.Write($"{sum1}\t");
        }
    
}


Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
SumMainDiagonal(matrix);


*/