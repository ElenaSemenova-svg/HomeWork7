// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] InitMatrix()
{
    double[,] matrix = new double[3, 4];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(-99,99) / 10.0;
        }
    }

    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,6:F2}", matrix[i, j]+ " ");
        }
        Console.WriteLine();
    }
}

double[,] matrix = InitMatrix();
PrintMatrix(matrix);

