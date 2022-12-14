Console.WriteLine("введите номер четверти координат");
int num = Convert.ToInt32(Console.ReadLine());
if (num<1 || num>4) { Console.WriteLine("есть всего четыре четверти!"); }
else if (num == 1) { Console.WriteLine("x>0, y>0"); }
else if (num == 2) { Console.WriteLine("x<0, y>0"); }
else if (num == 3) { Console.WriteLine("x<0, y<0"); }
else if (num == 4) { Console.WriteLine("x>0, y<0"); }