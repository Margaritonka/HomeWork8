// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

void PrintArray2(int [] matr)
{
        for (int i = 0; i < matr.Length; i++)
        {
            Console.Write(matr[i] + "   ");
        }
        Console.WriteLine();
}

int [] FillArr(int [] arr, int [,] ex)
{
    int i= 0;
    int k = 0;
for (int j = 0; j < ex.GetLength(0)+1; j++)
    {
                arr[k] = ex[i,j];
                k++;
    }
    return arr;
}

int [] FillArr1(int [] arr, int [,] ex)
{
    int i= 1;
    int k = 0;
for (int j = 0; j < ex.GetLength(0)+1; j++)
    {
                arr[k] = ex[i,j];
                k++;
    }
    return arr;
}

int [] FillArr2(int [] arr, int [,] ex)
{
    int i= 2;
    int k = 0;
for (int j = 0; j < ex.GetLength(0)+1; j++)
    {
                arr[k] = ex[i,j];
                k++;
    }
    return arr;
}
int [] SortArray(int [] arr)
{
int temp = 0;
for (int i = 0; i < arr.Length-1; i++)
{
    for (int j = i+1; j < arr.Length; j++)
    {
        if (arr[i] < arr[j])
        {
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
return arr;
}


int [,] ex = FillArray(3,4);
PrintArray(ex);

int [] arr = new int [4];
int [] arr1 = new int [4];
int [] arr2 = new int [4];

FillArr(arr,ex);
Console.WriteLine();
FillArr1(arr1,ex);
FillArr2(arr2,ex);
SortArray(arr);
SortArray(arr1);
SortArray(arr2);
PrintArray2(arr);
PrintArray2(arr1);
PrintArray2(arr2);
