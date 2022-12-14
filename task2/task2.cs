/*Написать программу, которая принимает два числа и  выдаёт какое большее, а какое - меньшее
Например: 2, 5. 2 - меньшее, 5 - большее */
Console.WriteLine("введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2)
{ 
    Console.WriteLine ("введённые числа равны");
}
    else if (num1 > num2) 
    {
        Console.WriteLine("первое введённое число - большее, второе - меньшее");
    }
    else 
    { 
        Console.WriteLine("первое число меньшее, второе - большее");
    }