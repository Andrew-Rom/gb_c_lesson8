/* Задача 54:
Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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

// Метод сортировки.
int[] SortArray(int[] array, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex)
    {
        return array;
    }
    int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);
    SortArray(array, minIndex, pivotIndex - 1);
    SortArray(array, pivotIndex + 1, maxIndex);
    return array;
}

// Метод определения опорного элемента.
int GetPivotIndex(int[] array, int minIndex, int maxIndex)
{
    int pivot = minIndex - 1;
    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (array[i] > array[maxIndex])
        {
            pivot++;
            Swap(ref array[pivot], ref array[i]);
        }
    }
    pivot++;
    Swap(ref array[pivot], ref array[maxIndex]);
    return pivot;
}

// Метод перестановки.
void Swap(ref int leftItem, ref int rightItem)
{
    int temp = leftItem;
    leftItem = rightItem;
    rightItem = temp;
}

// Размер генерируемого массива
int quantityRows = 5;
int quantityCols = 9;

int[,] randomMatrix = CreateMatrix(quantityRows, quantityCols);
PrintMatrix(randomMatrix);
Console.WriteLine();

int[,] sortedRandomMatrix = new int[quantityRows, quantityCols];
for (int i = 0; i < randomMatrix.GetLength(0); i++)
{
    int[] stringOfMatrix = new int[randomMatrix.GetLength(1)];
    for (int j = 0; j < randomMatrix.GetLength(1); j++)
    {
        stringOfMatrix[j] = randomMatrix[i, j];
    }
    stringOfMatrix = SortArray(stringOfMatrix, 0, stringOfMatrix.Length - 1);
    for (int jj = 0; jj < sortedRandomMatrix.GetLength(1); jj++)
    {
        sortedRandomMatrix[i, jj] = stringOfMatrix[jj];
    }
}
PrintMatrix(sortedRandomMatrix);