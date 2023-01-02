/* Задайте двумерный массив
из целых чисел. Найдите среднее арифметическое 
элементов каждого столбца
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца
4,6 5,6 3,6 3,0 
*/
int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] RandomArray(int rows, int columns, int LRange, int RRange)
{
    int[,] massiv = new int[rows, columns];
    Random rand = new Random();

        for (int i=0; i<massiv.GetLength(0); i++)
        {
          for (int j=0; j<massiv.GetLength(1); j++)
          {
            massiv[i,j] = rand.Next(LRange, RRange+1);
          }
        }
    return massiv;
}
void PrintArray(int[,] massiv)
{
    Console.WriteLine("исходный массив");
    for (int i=0; i<massiv.GetLength(0); i++)
        {
          for (int j=0; j<massiv.GetLength(1); j++)
          {
            Console.Write(massiv[i,j] + " ");
          }
          Console.WriteLine();
        }
}
int m = ReadNumber("количество строк: ");
int n = ReadNumber("количество столбцов: ");
int lowR = ReadNumber("нижний предел: ");
int highR = ReadNumber("верхний предел: ");
int[,] array = RandomArray(m, n, lowR, highR);
//int[,] digits = RandomArray()
PrintArray(array);
for (int i=0; i<array.GetLength(1); i++){
    double AriphMean = 0;
    for (int j=0; j<array.GetLength(0); j++)
    {
    AriphMean = AriphMean + array[j, i];
    }
    AriphMean = Math.Round((AriphMean/m),2);
    Console.Write(AriphMean + "| ");
}
