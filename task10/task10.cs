//Написать программу, которая принимает на вход трёхзначное число и выводит 2ю цифру этого числа
Console.WriteLine("введите трёхзначное число");
int num3 = Convert.ToInt16(Console.ReadLine());
int dig2 = num3/10%10;
Console.WriteLine(dig2);
