/* Задача 41
Пользователь вводит с клавиатуры М чисел
Посчитайте сколько чисел больше 0 ввёл пользователь. 
Ввод чисел останавливается после ввода слова stop */

int num = 0;
int count = 0;
string s = string.Empty;
Console.WriteLine("введите любое количество чисел через Enter, для окончания ввода введите stop")
do
{
 s = Console.ReadLine();
 if (s == "stop")
  {
    break;
  }
  else 
  {
    num = Convert.ToInt32(s);
    if (num>0) { count++; }
  }
}
while(true);
Console.WriteLine($"положительных чисел введено {count}"); 

