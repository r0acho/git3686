int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int rows1 = ReadInt("\nколичество строк первой матрицы: ");
int cols1 = ReadInt("\nколичество столбцов первой матрицы: ");
int rows2 = ReadInt("\nколичество строк второй матрицы: ");
int cols2 = ReadInt("\nколичество столбцов второй матрицы: ");
if (cols1!=rows2 && cols2!=rows1) 
{ 
    Console.WriteLine("матрицы умножить невозможно! Число столбцов и строк обеих матриц не совпадают");
}
else
{
int varr = ReadInt("диапазон случайных чисел от 0 до 9 из которых будут матрицы: ");
int[,] FirstMatrix = new int[rows1, cols1];
RandomArray(FirstMatrix);
Console.WriteLine("первая матрица");
PrintArray(FirstMatrix);
int[,] SecondMatrix = new int[rows2, cols2];
RandomArray(SecondMatrix);
Console.WriteLine("вторая матрица");
PrintArray(SecondMatrix);
int[,] result = MatrixProduct(FirstMatrix, SecondMatrix);
Console.WriteLine("произведение матриц: ");
PrintArray(result);
void RandomArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(varr);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] MatrixProduct(int [,] FirstMatr, int[,] SecondMatr)
{
    int[,] resultArray = new int[FirstMatr.GetLength(0),SecondMatr.GetLength(1)];
    for (int i=0; i<FirstMatr.GetLength(0); i++)
    {
        for (int j=0; j<SecondMatr.GetLength(1);j++)
        {
            resultArray[i,j] += FirstMatr[i,j]*SecondMatr[i,j]; 
        }
    }
    return resultArray;
}
}