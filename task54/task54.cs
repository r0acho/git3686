/* Задайте двумерный массив
Напишите программу, которая упорядочит
по возрастанию элементы каждой строки двумерного массива
1 4 7 2
5 9 2 3
8 4 2 4
_________
1 2 4 7
2 3 5 9
2 4 4 8
*/
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int rows = ReadInt("количество строк");
int cols = ReadInt("количество столбцов");
int varr = ReadInt("диапазон случайных чисел от 1 до 10: ");
void RandomnyjMassiv(int[,] array)
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
            Console.Write(array[i,j] + "  ");
        }
        Console.WriteLine();
    }
}
void SortUpArray(int[,] array)
{
  for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            for (int k=0; k<array.GetLength(1)-1; k++)
            {
                if (array[i,k]>array[i,k+1])
                {
                    int temp = array[i, k+1];
                    array[i,k+1] = array[i,k];
                    array[i,k] = temp;
                }
            }  
        }
    }
}
int[,] array = new int[rows, cols];
RandomnyjMassiv(array);
PrintArray(array);
Console.WriteLine("\n\tотсортированный массив");
SortUpArray(array);
PrintArray(array);