﻿/* Написать программу, которая принимает три числа и выдаёт максимальное из них
2, 6, 9 -> 9
22, 78,11 -> 78
*/
Console.WriteLine("введите три любых целых числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int max;
if (num1 == num2 && num1 == num3 && num2 == num3)
{
    Console.WriteLine("все числа равны");
}
    else if (num1 > num2 && num2 > num3)
    {
        max = num1;
        Console.WriteLine(max);
    }
        else if (num1 < num2 && num2 > num3)
        {
            max = num2;
            Console.WriteLine(max);
        }
            else 
            {
                max = num3;
                Console.WriteLine($"максимальное число из введённых = {max}"); 
            }


