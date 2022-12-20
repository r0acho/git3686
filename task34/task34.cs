/* Задайте массив, заполненный случайными положительными трёхзначными числами и напишите программу, 
которая покажет в этом массиве количество чётных чисел */
int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];
    Random rand = new Random();
    for (int i=0; i<array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange+1);
    }
    return array;
}
int CountEvenNumber(int[] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        if(array[i]%2==0) count++;
    } 
    return count;
}
const int LENGHT = 10;
const int LEFTR = 100;
const int RIGHTR = 999;
int[] massiv = GetRandomArray(LENGHT, LEFTR, RIGHTR);
Console.WriteLine($"[{string.Join(", ", massiv)}]");
int EvenCount = CountEvenNumber(massiv);
Console.WriteLine($"Количество чётных элементов: {EvenCount}");
