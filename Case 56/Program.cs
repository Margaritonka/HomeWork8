// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



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

int [] FillArr(int [] arr, int [,] ex)
{
    int i= 0;
    int sum = 0;
    int sum1 = 0;
    int sum2 = 0;
    for (int j = 0; j < ex.GetLength(1); j++)
        {
                sum += ex[i,j];

        }

arr[0] = sum;

i = 1;

    for (int j = 0; j < ex.GetLength(1); j++)
        {
                sum1 += ex[i,j];
        }

arr[1] = sum1;

i = 2;

    for (int j = 0; j < ex.GetLength(1); j++)
    {
                sum2 += ex[i,j];
    }

arr[2] = sum2;

    return arr;
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

// void PrintArray2(int [] matr)
// {
//         for (int i = 0; i < matr.Length; i++)
//         {
//             Console.Write(matr[i] + "   ");
//         }
//         Console.WriteLine();
// }

int MinRow(int [] sum)
{
int min = sum[0];
int iMin = 0;
for (int i = 0; i < sum.Length; i++)
{
    if (sum[i] < min)
        {
            min = sum[i];
            iMin = i;
        }
}
return min;
}

int [,] array = FillArray(3,5);
PrintArray(array);
int [] sum = new int [3];

FillArr(sum,array);

// PrintArray2(sum);


if (sum[0] == MinRow(sum)) Console.Write($"Минимальное значение суммы элементов в строке 1 ");
if (sum[1] == MinRow(sum)) Console.Write($"Минимальное значение суммы элементов в строке 2");
if (sum[2] == MinRow(sum)) Console.Write($"Минимальное значение суммы элементов в строке 3");