/* задайте прямоугольный двумерный массив. 
Напишите программу, которая будет искать строку 
с наименьшей суммой элементов
Например задан массив 
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой стоке и выводит номер строки с наименьшей суммой элементов
1 строка
*/
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] RandArray(int rows, int cols, int leftRange, int rightRange)
{
  int[,] array = new int[rows, cols];
  Random rand = new Random();
  for (int i = 0; i<array.GetLength(0); i++)
  {
    for (int j = 0; j<array.GetLength(1); j++)
    {
        array[i,j] = rand.Next(leftRange, rightRange+1);
    }
   }  
   return array;
}
void PrintArray(int[,] array)
{
  for (int i = 0; i<array.GetLength(0); i++)
  {
    for (int j = 0; j<array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
   }  
}
int SummOfString(int[,] array, int i)
{
    int summString = array[i,0];
    for (int j=1; j<array.GetLength(1); j++)
    {
        summString += array[i,j]; 
    }
    return summString;
}
int ROWS = ReadInt("количество строк: ");
int COLS = ReadInt("количество столбцов: ");
int LEFTRANGE = ReadInt("нижний предел массива: ");
int RIGHTRANGE = ReadInt("верхний предел массива: ");
if (ROWS==COLS) 
Console.WriteLine("массив по условию задачи должен быть прямоугольным!");
else {
    int[,] array = RandArray(ROWS,COLS,LEFTRANGE,RIGHTRANGE);
    PrintArray(array);
    int minSumm = 0;
    int SummString = SummOfString(array,0);
    for (int i=1; i<array.GetLength(0); i++)
    {
        int tempSummLine = SummOfString(array, i);
        if (SummString>tempSummLine)
        {
            SummString = tempSummLine;
            minSumm = i;
        }
    }
    Console.WriteLine($"\nНаименьшая сумма элементов в строке под номером {minSumm} равна {SummString}");
}
