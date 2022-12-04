// Напишите программу, котррая на вход принимает целое число
//и проверяет его на чётность
Console.WriteLine("введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)  { Console.WriteLine("введённое число чётное"); } 
    else Console.WriteLine("число нечётное");