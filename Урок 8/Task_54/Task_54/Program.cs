// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] OrderingRowsToMin(int[,] mas, int rows, int columns)
{
    int[,] mas2 = (int[,])mas.Clone();
    int buffer = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int temp = 0; temp < columns - 1; temp++)
            {
                if (mas2[i, temp] < mas2[i, temp + 1])
                {
                    buffer = mas2[i, temp + 1];
                    mas2[i, temp + 1] = mas2[i, temp];
                    mas2[i, temp] = buffer;
                }
            }
        }
    }
    return mas2;
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
int[,] mas2 = OrderingRowsToMin(mas, rows, columns);
PrintMas(mas2);