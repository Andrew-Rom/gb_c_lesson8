/* Задача 56:
Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер 
строки с наименьшей суммой элементов: 1 строка */

// Метод генерации массива.
int[,] CreateMatrix(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(-99, 100);
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

// Размер генерируемого массива
int quantityRows = 7;
int quantityCols = 10;

int[,] randomMatrix = CreateMatrix(quantityRows, quantityCols);
Console.WriteLine("В массиве:");
PrintMatrix(randomMatrix);
Console.WriteLine();
int indexOfMinRow = 0;
int minSumItemsInRow = 0;
for (int i = 0; i < randomMatrix.GetLength(0); i++)
{
    int sumItemsInRow = 0;
    for (int j = 0; j < randomMatrix.GetLength(1); j++)
    {
        sumItemsInRow = sumItemsInRow + randomMatrix[i, j];
    }
    
    if (sumItemsInRow < minSumItemsInRow)
    {
        minSumItemsInRow = sumItemsInRow;
        indexOfMinRow = i;
    }
}
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {indexOfMinRow + 1} строка.");