// // Задача 50. Напишите программу, которая на вход принимает позиции 
// // элемента в двумерном массиве, и возвращает значение этого элемента
// // или же указание, что такого элемента нет.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 17 -> такого числа в массиве нет


void CheckElementOfArray2(int[,] array)
{
    int n = PromptNumber("Введите порядковый номер искомого элемента в массиве: (1, 2, ...): ");
    int columnIndex = n % array.GetLength(1) - 1;   // индекс столбца, в котором находится элемент
    int rowIndex = n / array.GetLength(1);          // индекс строки, в которой находится элемент
    if (n > array.GetLength(0) * array.GetLength(1))
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
    else if (n % array.GetLength(1) == 0)   // костыль для последнего столбцв
    {
        columnIndex = array.GetLength(1) - 1;
        rowIndex = n / array.GetLength(1) - 1;
    }
    Console.WriteLine($"Искомый элемент равен: {array[rowIndex, columnIndex]}");
}

int PromptNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] GenerateRandomArray2D(int rows, int columns, int from, int to)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(from, to);
        }
    }
    return array;
}

int m = PromptNumber("Задайте количество строк массива: ");
int n = PromptNumber("Задайте количество столбцов массива: ");
int[,] matrix = GenerateRandomArray2D(m, n, 10, 100);
Console.WriteLine("Сгенерирован двумерный массив");
PrintArray2D(matrix);
CheckElementOfArray2(matrix);