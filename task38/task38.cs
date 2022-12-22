// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
void RandoMassiv(int[] elements)
{
    for (int i=0; i<elements.Length; i++)
    {
        elements[i] = new Random().Next(1,100);
    }
}
void PrintMassiv(int[] elements)
{
    for (int i=0; i<elements.Length; i++) { Console.Write(elements[i] + " "); }
    Console.WriteLine();
}
Console.WriteLine("задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] elements = new int[size];
int min = Int32.MaxValue;
int max = Int32.MinValue;
RandoMassiv(elements);
Console.WriteLine("А вот и массив!");
PrintMassiv(elements);
for (int i=0; i<elements.Length; i++)
{
    if (elements[i]>max) { max = elements[i]; }
    if (elements[i]<min) { min = elements[i]; }
}
Console.WriteLine($"max = {max}, min = {min}, разница между max и min = {max - min}");

