// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array1 = { { 2, 4 }, { 3, 2 } };
int[,] array2 = { { 3, 4 }, { 3, 3 } };
int[,] array3 = new int[2, 2];

void MatrixProduct(int[,] array3)
{
    int i = 0;
    int j = 0;
    array3[i, j] = (array1[i, j] * array2[i, j]) + (array1[i, j + 1] * array2[i + 1, j]);
    array3[i, j + 1] = (array1[i, j] * array2[i, j + 1]) + (array1[i, j + 1] * array2[i + 1, j + 1]);
    array3[i + 1, j] = (array1[i + 1, j] * array2[i, j]) + (array1[i + 1, j + 1] * array2[i + 1, j]);
    array3[i + 1, j + 1] = (array1[i + 1, j] * array2[i, j + 1]) + (array1[i + 1, j + 1] * array2[i + 1, j + 1]);

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


MatrixProduct(array3);
PrintArray(array3);
