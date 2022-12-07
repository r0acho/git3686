/* Программа выводит третью цифру заданного пользователем числа и если число меньше трёх знаков, сообщает об этом
345 -> 5
6543 -> 4
88 -> третьей цифры нет */
Console.WriteLine("введите какое-нибудь целое число!");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 100) {Console.WriteLine("в данном числе нет третьей цифры"); }
    else {
            for (; num>=1000; num = num/10);
            Console.WriteLine(num % 10);
    }
