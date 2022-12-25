/* Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
​ (в примере подсчет индексов начинается с 1 , как в математике)
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
​
Новый массив будет выглядеть
вот так:
1 4 7 2
5 81 2 9
8 4 2 
*/
int ReadInt(string message) 
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    int[,] matr = new int[rows, columns];

    var rand = new Random();
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matr;
}
void PrintMatrix(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
    }
}
int Diagonal(int[,] matr)
{
    int summa = 0;
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        if (i == j) summa += matr[i,j];   
    }
    return summa;
}
int rowsCount = ReadInt("Введите число строк");
int columnsCount = ReadInt("Введите число столбцов");
int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);
int sum = Diagonal(matrix);
Console.WriteLine($"сумма элементов с одинаковыми индексами равна {sum}");