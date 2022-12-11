// Написать программу, которая принимает число и считает сумму цифр в числе
int ReadNum(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int GetSummDigits(int number)
{
    int sum = 0;
    if (number < 0) 
    { 
        Console.WriteLine("ввели отрицательное число? Ща по модулю возмём да сумму посчитаем");
        number = Math.Abs(number);
        while (number > 0)
        {
          sum = sum + number %10;
          number /= 10;  
        }
        return sum;
    }
    else 
    {
        while (number > 0)
        {
            sum = sum + number % 10;
            number /= 10;
        }
    }
    return sum;
}
int num = ReadNum("введите число");
int result = GetSummDigits(num);
Console.WriteLine($"сумма цифр {num} = {result}");