/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
int ReadNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void TakeDigitString(int N, int digit)
{
    if (digit>N)
    {
        return;
    }
    else 
    {
        TakeDigitString(N, digit+1);
        Console.Write(digit + ", ");
    }
}
int N = ReadNum("введите число, до которого вывести числовой ряд: ");
int digit = 2; //чтобы последняя цифра не шла с запятой
TakeDigitString(N, digit);
Console.Write("1");

