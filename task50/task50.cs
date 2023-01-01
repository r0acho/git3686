/*Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
​Например, задан массив:
​1 4 7 2
​
5 9 2 3
​
8 4 2 4
​
1 7 -> такого числа в массиве нет
​*/
int ReadNum(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] RandoMatrix(int leftR, int rightR, int rows, int cols)
{
    int[,] matrix = new int[rows,cols];
    Random rand = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftR, rightR + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int LEFTR = ReadNum("нижний предел массива: ");
int RIGHTR = ReadNum("верхний предел массива: ");
int rowsCount = ReadNum("количество строк: ");
int colsCount = ReadNum("количество столбцов: ");
int[,] newMatrix = RandoMatrix(LEFTR, RIGHTR, rowsCount, colsCount);
PrintMatrix(newMatrix);
int ROWS = ReadNum("индекс строки");
int COLS = ReadNum("индекс столбца");
if (ROWS<newMatrix.GetLength(0) && COLS<newMatrix.GetLength(1))
Console.WriteLine($"найденное число: {newMatrix[ROWS, COLS]}");
else Console.WriteLine($"[{ROWS} {COLS}] числа с такими индексами нет в массиве");
