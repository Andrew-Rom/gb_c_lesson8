/*Задача 58:
Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

// Метод генерации массива.
int[,] CreateMatrix(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

// Метод вывода массива.
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

// Метод проверки размеров матриц.
bool IsValidSizeOfArray(int quantityRowsOfMatrix1,
                        int quantityColsOfMatrix1,
                        int quantityRowsOfMatrix2,
                        int quantityColsOfMatrix2)
{
    return (quantityRowsOfMatrix1 == quantityColsOfMatrix2 &&
            quantityRowsOfMatrix2 == quantityColsOfMatrix1);
}

// Размер генерируемых матриц.
int m = 2;
int n = 3;

int[,] matrix1 = CreateMatrix(m, n);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrix(n, m);
PrintMatrix(matrix2);
Console.WriteLine();

bool isValid = IsValidSizeOfArray(
                        quantityRowsOfMatrix1: matrix1.GetLength(0),
                        quantityColsOfMatrix1: matrix1.GetLength(1),
                        quantityRowsOfMatrix2: matrix2.GetLength(0),
                        quantityColsOfMatrix2: matrix2.GetLength(1)
                        );

if (isValid)
{
    int[,] resultOfMatrixMultiplication = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    int temp = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {        
        for (int k = 0; k <matrix2.GetLength(1); k++)
        {
            for (int j = 0; j < matrix2.GetLength(0); j++)
            {
                temp = temp + matrix1[i, j] * matrix2[j, k];
            }
            resultOfMatrixMultiplication[i, k] = temp;
            temp = 0;
        }
    }
    PrintMatrix(resultOfMatrixMultiplication);
}
else
{
    Console.WriteLine("Ошибка");
}