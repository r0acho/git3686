/*Задача 35: Задайте одномерный массив из 123 случайных чисел 
в диапазоне [0, 150]. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99]. */

int[] SuperMassive(int size, int minRange, int maxRange)
	{
        int[] massiv = new int[size];
		Random rand = new Random();
		for (int i=0; i<massiv.Length; i++)
		{ massiv[i]=rand.Next(minRange,maxRange+1); }
	    return massiv;
   }
int CountNumbersRange(int[] massiv)
    {
	int count = 0;
	for (int i=0; i<massiv.Length; i++)
		{
		if (massiv[i]>=10 && massiv[i]<=99)
			count++;
		}
		return count;
	}
const int MINRANGE = 0;
const int MAXRANGE = 150;
const int SIZE = 123;
int[] megArray = SuperMassive(SIZE, MINRANGE, MAXRANGE); 
Console.WriteLine($"[{string.Join(", ", megArray)}]");
int rangeCount = CountNumbersRange(megArray);
Console.WriteLine($"Количество элементов в диапазоне [10;99]: {rangeCount}");



