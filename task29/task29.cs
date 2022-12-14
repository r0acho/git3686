// Программа запрашивает у пользователя 8 чисел и выводит их в массив
int Length = 8;
int[] Array  = new int[Length]; 
Console.WriteLine("введите восемь чисел");
for (int i=0; i<Length; i++)
{
    Console.Write($"[{i}]:\t");
    Array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("вывод массива: ");
Console.WriteLine(string.Join(" , " , Array));


