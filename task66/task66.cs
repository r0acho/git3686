/* Задача 66:
Задайте значения M и N. Напишите программу
которая найдёт сумму натуральных чисел
в диапазоне [M; N] */
int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void NaturlichSumm(int M, int N, int summ)
{
    summ = summ+N;
    if (N<=M)
    {
        Console.Write($"Сумма элементов: {summ}");
        return;
    }
    NaturlichSumm(M, N-1, summ);
}
int M = ReadNumber("M = ");
int N = ReadNumber("N = ");
int step = M;
NaturlichSumm(M,N,step=0);
