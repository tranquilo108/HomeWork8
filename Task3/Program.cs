/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


int[,] a =
{
    { 2, 4 },
    { 3, 2 }
};
int[,] b =
{
    { 3, 4 },
    { 3, 3 }
};

int[,] c = new int[a.GetLength(0), a.GetLength(1)];
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        for (int k = 0; k < a.GetLength(0); k++)
        {
            c[i, j] += a[i, k] * b[k, j];
        } 
    }
}

void PrintArray(int[,] ints)
{
    Console.WriteLine("Результирующая матрица: ");

    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
        {
            Console.Write($"{ints[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


PrintArray(c);