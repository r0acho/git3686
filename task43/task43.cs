/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y1 =k1*x+b1; y2 = k2*x+b2.
k1, k2,b1,b2 задаются пользователем
*/
double InputLineParam(string message)
{
    Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine());
}
double k1 = InputLineParam("введите k1: ");
double b1 = InputLineParam("введите b1: ");
double k2 = InputLineParam("введите k2: ");
double b2 = InputLineParam("введите b2: ");
if (k1==k2)
{
    Console.WriteLine("Линии параллельны!");
}
else {
    double x = (b1-b2)/(k2-k1);
    double y = k2*x + b2;
    Console.WriteLine($"Точка пересечения прямых с заданными параметрами ({x:f2};{y:f2})");
}
