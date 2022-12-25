/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/


int[,] newarray =
{
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 }
};

static void NewMethod(int[,] newarray)
{
    for (int i = 0; i < newarray.GetLength(0); i++)
    {
        for (int j = 0; j < newarray.GetLength(1); j++)
        {
            for (int k = 0; k < newarray.GetLength(1) - 1; k++)
            {
                if (newarray[i, k] < newarray[i, k + 1])
                {
                    int temp = newarray[i, k];
                    newarray[i, k] = newarray[i, k + 1];
                    newarray[i, k + 1] = temp;
                }
            }
        }
    }
}

void PrintArray(int[,] ints)
{
    Console.WriteLine("Заданный массив");
    Console.WriteLine();
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


NewMethod(newarray);
PrintArray(newarray);