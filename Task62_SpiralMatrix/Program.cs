/* Задача 62.
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int squareMatrixSize = 4;

// Формирование квадратной матрицы и заполнение ее по спирали.
int[,] squareMatrix = new int[squareMatrixSize, squareMatrixSize];
int row = 0;
int col = 0;
int matrixValue = 1;
while (matrixValue <= squareMatrix.Length)
{
    squareMatrix[row, col] = matrixValue;
    matrixValue++;
    if (row <= col + 1 && (row + col) < (squareMatrix.GetLength(1) - 1))
    {
        col++;
    }
    else if (row < col && (row + col) >= (squareMatrix.GetLength(0) - 1))
    {
        row++;
    }
    else if (row >= col && (row + col) > (squareMatrix.GetLength(1) - 1))
    {
        col--;
    }
    else
    {
        row--;
    }
}

// Добавление нулей для корректного отображения сформированной матрицы и ее вывод.
string[,] outputMatrix = new string[squareMatrix.GetLength(0), squareMatrix.GetLength(1)];
for (int i = 0; i < outputMatrix.GetLength(0); i++)
{
    for (int j = 0; j < outputMatrix.GetLength(1); j++)
    {
        outputMatrix[i, j] = squareMatrix[i, j].ToString();
        if (outputMatrix[i, j].Length < 2)
        {
            outputMatrix[i, j] = "0" + outputMatrix[i, j];
        }
        Console.Write($"{outputMatrix[i, j]} ");
    }
    Console.WriteLine();
}