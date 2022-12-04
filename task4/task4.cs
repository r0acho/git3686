/* Написать программу, которая принимает три числа и выдаёт максимальное из них
2, 6, 9 -> 9
22, 78,11 -> 78
*/
Console.WriteLine("введите три любых целых числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int max;
if (num1 == num2 && num1 == num3 && num2 == num3) { Console.WriteLine("все числа равны"); }
    else if (num1 > num2 && num2 > num3) { Console.WriteLine(max=num1); }
        else if (num1 < num2 && num2 > num3) { Console.WriteLine(max=num2); }
            else { Console.Write(max = num3); }


