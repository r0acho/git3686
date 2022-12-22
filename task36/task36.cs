/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] massiv = new int[size];
    Random rand = new Random();
    for (int i=0; i<massiv.Length; i++)
    {
        massiv[i] = rand.Next(leftRange, rightRange+1);
    }
    return massiv;
}
int SummNonevenPos(int[] massiv)
{
    int summ = 0;
    for (int index=1; index<massiv.Length; index+=2)
    {
        summ = summ+massiv[index];
    }
    return summ;
}
Console.WriteLine("введите размерность массива");
int SIZE = Convert.ToInt32(Console.ReadLine());
//const int SIZE = 10;
const int LEFTR = -20;
const int RIGHTR = 20;
int[] Array = GetRandomArray(SIZE,LEFTR, RIGHTR);
Console.WriteLine($"[{string.Join(", ", Array)}]");
int Sum = SummNonevenPos(Array);
Console.WriteLine($"Сумма элементов нечётных позиций = {Sum}");
