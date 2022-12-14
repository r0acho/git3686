//Написать программу, которая принимает на вход трёхзначное число и выводит 2ю цифру этого числа
Console.WriteLine("введите трёхзначное число");
int num3 = Convert.ToInt16(Console.ReadLine());
if (num3<100 || num3 > 999) Console.WriteLine("введённое число вне требуемого диапазона");
else {
    int dig2 = num3/10%10;
    Console.WriteLine($"{dig2}");
    }
