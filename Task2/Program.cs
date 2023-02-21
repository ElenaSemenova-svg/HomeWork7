// // Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int GetNumber(string message)
{
int result = 0;
while (true)
{
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine(), out result) && result >= 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное число! Повтороите ввод");
    } 
}
return result;
}

int[,] InitMatrix()
{
    int[,] matrix = new int[3, 4];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SearchElement(int[,] matrix, int number1, int number2)
{
    int valueOfElements = 0;
    if (number1 < matrix.GetLength(0) && number2 < matrix.GetLength(1))
    {
        valueOfElements = matrix[number1, number2];
        Console.WriteLine($" Значение элемента {valueOfElements}");
    }
    else
    {
        Console.WriteLine("Элемента с такой позицией нет");
    }
}


int[,] matrix = InitMatrix();
PrintMatrix(matrix);
Console.WriteLine();
int number1 = GetNumber(" Введите номер строки элемента:");
int number2 = GetNumber(" Введите номер столбца элемента:");
SearchElement(matrix, number1, number2);

