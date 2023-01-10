/* Заполните спирально массив 4х4 
На выходе должно получиться примерно так:
1  2  3  4
12 13 14 5
11 16 15 6
10 9  8  7 
*/
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int n = ReadInt("введите размер массива одним числом");
int step = 1;
int[,] matrix = new int[n,n];
int i=0;
int j=0;
void PrintMatrix(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "  ");
        }
        Console.WriteLine();
    }
}
while (step <= matrix.GetLength(0)*matrix.GetLength(1))
{
    matrix[i,j] = step;
    step++;
    if (i<=j+1 && i+j<matrix.GetLength(1)-1)
    j++;
    else if (i<j && i+j >= matrix.GetLength(0)-1)
    i++;
    else if (i>=j && i+j > matrix.GetLength(1)-1)
    j--;
    else i--;
}
PrintMatrix(matrix);