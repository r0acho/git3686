/* задайте двумерный массив, заполненный случайными 
вещественными числами
m = 3, n = 4 - запрашиваются у пользователя
-1.5 5.7 6.4 -1.4
1.6 -3.4 11.7 7.1
11.5 -1.1 6.4 -2.1
*/
int ReadNumbers(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
double[,] GetRandomArray(int rows, int columns, double leftR = -10.0, double rightR = 10.0)
{
    double[,] matr = new double[rows, columns];
    var rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToDouble(rand.Next(-100,100)/10.00);
        }
    }
    return matr;
}
void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,6:F1}", matr[i, j]));
        }
        Console.WriteLine();
    }
}
int rowsCount = ReadNumbers("количество строк: ");
int columnCount = ReadNumbers("количество столбцов: ");
double[,] matrix = GetRandomArray(rowsCount, columnCount);
PrintArray(matrix);

