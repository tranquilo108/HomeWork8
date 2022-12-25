/*
Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */


int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result)) break;
        else Console.WriteLine("Ввели не число");
    }
    return result;
}

int[,] InitMatrix(int side)
{
    int count = 1, i = 0, j = 0;
    int[,] matrix = new int[side, side];
    for (int a = 0; a < side / 2; a++)
    {
        for (i = a; i < side - a - 1; i++)
        {
            matrix[a, i] = count++;
        }
        for (j = a; j < side - a - 1; j++)
        {
            matrix[j, i] = count++;
        }
        for (i = side - a - 1; i > a; i--)
        {
            matrix[j, i] = count++;
        }
        for (j = side - a - 1; j > a; j--)
        {
            matrix[j, i] = count++;
            if (count == side * side)
            {
                matrix[j, i + 1] = count;
            }
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
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int side = GetNumber("Введите количество строк ");
int[,] matrix = InitMatrix(side);
PrintMatrix(matrix);
