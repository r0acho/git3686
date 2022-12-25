Console.WriteLine("введите число в интервале от 1 до 7");
int num_day = Convert.ToInt32(Console.ReadLine());
if (num_day<1 || num_day>7) Console.WriteLine("вы ввели число  вне диапазона"); 
    else if (num_day > 5) Console.WriteLine("Это выходной, трудяга!"); 
        else Console.WriteLine("Прости, товарищ, но труба зовёт - арбайтен! Шнель!");
