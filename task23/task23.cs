// Написать программу, которая принимает на вход число N и выдаёт таблицу кубов чисел от 1 до N 
Console.WriteLine("введите количество чисел, которые следет возвести в третью степень");
int N = Convert.ToInt32(Console.ReadLine());
if (N<=0) Console.WriteLine("количество не может быть нулевым или отрицательным"); 
    else {
        for (int i = 1; i<=N; i++) { Console.WriteLine($"{i} ^ 3 = {Math.Pow(i,3)}"); }
    }
