Console.WriteLine("vvedite основание и степень");
int osn = Convert.ToInt32(Console.ReadLine());
int step = Convert.ToInt32(Console.ReadLine());
double Stepen(int n, int m)
{
    if(m == 0) return 1;
    n *= Stepen(n, m-1);
    return n;
}
Console.WriteLine(Stepen(osn, step));