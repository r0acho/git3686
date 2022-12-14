/* Программа принимает от пользователя два числа и возводит одно в степень другого 
Например А и В. Написать код без использование функции Math.Pow и ей подобных 
5, 3 -> 125
6, 4 -> 1296 */
/*Console.WriteLine("введите основание степени");
int osnova = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите показатель степени");
int step = Convert.ToInt32(Console.ReadLine());
double result = 1;
if (step == 0) {Console.WriteLine($"{osnova}^0 = 1"); }
    else if (step>0) 
    {
        for (int i = 1; i <= step; i++)
        result *= osnova;
    }
    else if (step<0) 
    {
        for (int i = -1; i>= step; --i) result /= osnova;
    }
Console.WriteLine($"{result:f6}");*/
int ReadIntOsn(string message1)
{
    Console.WriteLine(message1);
    return Convert.ToInt32(Console.ReadLine());
}
int ReadIntStep(string message2)
{
    Console.WriteLine(message2);
    return Convert.ToInt32(Console.ReadLine());
}
double StepOfNumber(int number, int step)
{
    double res = 1;
    if (step == 0) { Console.WriteLine("любое число в нулевой степени - 1"); }
    else if (step>0) {
        for (int i=1; i<=step; i++)
        res *= number;
    }
    else if (step<0) {
        for (int i = -1; i>=step; --i) res /= number;
    }
    return res;
}
int osnova = ReadIntOsn("введите основание степени");
int steppow = ReadIntStep("введите показатель степени ");
double result = StepOfNumber(osnova, steppow);
Console.WriteLine($"{osnova}^{steppow} = {result:f4}");

