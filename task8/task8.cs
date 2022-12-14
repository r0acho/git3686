/* Напишите программу, которая принимает на вход некоторое число N
и выводит все чётные числа от 1 до N.
Например: 7 -> 2, 4, 6 */
Console.WriteLine("введите число");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
    {
        if (i % 2 == 0) { Console.Write(i + " "); }
    }