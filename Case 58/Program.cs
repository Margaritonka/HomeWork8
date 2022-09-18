// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] FillArray(int m, int n)
{
    int [,] array = new int [m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int [,] ex = FillArray(2,2);
int [,] exy = FillArray(2,2);
PrintArray(ex);
Console.WriteLine();
PrintArray(exy);

int [,] final = new int[2,2];
final[0,0] = ex[0,0] * exy[0,0] + ex[0,1] * exy[1,0];
final[1,0] = ex[1,0] * exy[0,0] + ex[1,1] * exy[1,0];
final[0,1] = ex[0,0] * exy[0,1] + ex[0,1] * exy[1,1];
final[1,1] = ex[1,0] * exy[0,1] + ex[1,1] * exy[1,1];

Console.WriteLine();
PrintArray(final);


