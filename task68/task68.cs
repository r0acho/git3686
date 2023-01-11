// Напишите программу вычисления числа Аккермана с помощью рекурсии
Console.WriteLine("Большая просьба не вводить числа больше чем 3! Это может привести к перегрузке системы!");
int ReadNumber(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine());
}
int Akkerman(int m, int n)
{
    if (m==0)
    {
        return n+1;
    
    }
    else if (n==0)
    {
        return Akkerman(m-1,1);
    }
    else 
    {
        return Akkerman(m-1, Akkerman(m,n-1));
    }
}
int m = ReadNumber("m = ");
int n = ReadNumber("n = ");
double PrintAkkerman = Akkerman(m,n);
Console.WriteLine($"Функция Аккермана: {PrintAkkerman}");


