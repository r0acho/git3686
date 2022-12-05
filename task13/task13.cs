//Написать программу, которая выводит третью цифру заданного числа или 
//сообщает что её нет
//782 -> 2
//87 -> третьей цифры нет
//6754 -> 5
Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
int digit3;
if (num < 100) { Console.WriteLine("третьей цифры нет!"); }
    else if (num >= 100 && num <= 999) 
    { Console.WriteLine(digit3 = num % 10); }
        else if (num >= 1000 && num <= 9999) { Console.WriteLine(digit3 = num % 100/10); }
            else if (num >=10000 && num <=99999) { Console.WriteLine(digit3 = num % 1000/100); }