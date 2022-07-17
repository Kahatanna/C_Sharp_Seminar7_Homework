/*

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

*/

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = randomizer.Next(-99, 100);
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
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void CheckItems(int[,] matrix, int x, int y)
{
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);

    if ((x > m) || (y > n)) Console.WriteLine("Такого элемента в массиве нет");
    else Console.WriteLine($"Элемент массива на позиции {x}, {y} = {matrix[x - 1, y - 1]}");
}

Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());

int[,] matrix = InitMatrix(m, n);

Console.WriteLine($"Матрица размером {m}x{n}:");
Console.WriteLine();

PrintMatrix(matrix);

Console.WriteLine();
Console.WriteLine("Введите позицию элемента по горизонтали:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите позицию элемента по вертикали:");
int y = int.Parse(Console.ReadLine());

CheckItems(matrix, x, y);

