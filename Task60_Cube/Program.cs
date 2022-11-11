/* Задача 60.
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

// Метод генерации массива.
int[,,] CreateCube(int row, int col, int depth)
{
    int[,,] cube = new int[row, col, depth];
    Random rnd = new Random();
    int cubeValue = rnd.Next(10, 20);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                cubeValue = cubeValue + rnd.Next(5, 10) - rnd.Next(1, 5);
                cube[i, j, k] = cubeValue;
            }
        }
    }
    return cube;
}

// Метод вывода массива.
void PrintMatrix(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                Console.Write($"{cube[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
    }
}

// Размер генерируемого массива.
int cubeHeight = 2;
int cubeWidth = 2;
int cubeDepth = 2;

int[,,] randomCube = CreateCube(
                            row: cubeHeight,
                            col: cubeWidth,
                            depth: cubeDepth);
PrintMatrix(randomCube);