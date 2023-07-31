// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArifmet(int[,] mas)
{
    Console.Write($"Среднее арифметического каждого столбца: ");
    double sum = 0;
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            sum = sum + mas[i, j];
        }
        Console.Write($" {Math.Round((sum / mas.GetLength(0)), 1)} ");
        sum = 0;
    }
}

void PrintMas(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] GenerateMas(int rows, int columns, int numMin, int numMax)
{
    int[,] mas = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            mas[i, j] = new Random().Next(numMin, numMax);
        }
    }
    return mas;
}

int GetInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInput("Введите количество строк в массиве: ");
int columns = GetInput("Введите количество строк в массиве: ");
int numMin = GetInput("Введите минимальный элемент массива: ");
int numMax = GetInput("Введите максимальный элемент массива: ");
Console.WriteLine();
int[,] mas = GenerateMas(rows, columns, numMin, numMax);
PrintMas(mas);
Console.WriteLine();
PrintArifmet(mas);