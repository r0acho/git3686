/* Задача 41
Пользователь вводит с клавиатуры М чисел
Посчитайте сколько чисел больше 0 ввёл пользователь. 
Ввод чисел останавливается после ввода слова stop */

int ReadInt(string msg)
{
  Console.WriteLine(msg);
  return Convert.ToInt32(Console.ReadLine());
}
int count = 0;
while (true)
{
    string msg = Console.ReadLine();
    if (msg == "stop")
    {
        break;
    }
    else {
    double.TryParse(msg, out double EnterNumber);
    if(EnterNumber>0)
       {
        count++;
       }
    }
}

Console.WriteLine(count);