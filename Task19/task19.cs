/* Написать программу, которая запрашивает у пользователя 
пятизначное число и проверяет это число: палиндром или нет */
Console.WriteLine("введите пятизначное число");
		int num = Convert.ToInt32(Console.ReadLine());
		if (num < 10000 && num > 99999) { Console.WriteLine("по условию задачи нужно пятизначное, а ты что ввёл/ввела???"); }
		   else {
				 int digit1 = num/10000; int digit2 = num/1000%10;
				 int digit4 = num/10%10; int digit5 = num%10; 
				   if (digit1 == digit5 && digit2 == digit4)
				 { Console.WriteLine("введённое число - палиндром"); }
				 else Console.WriteLine("введённое число палиндромом не является!");
			 }
	


