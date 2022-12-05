// Написать программу, которая принимает цифру, обозначающую день недели и проверяет, 
//является ли этот день выходным
//1 -> monday нет
//2 -> tuesday нет
//7 -> sunday да
Console.WriteLine("введите номер дня недели");
byte n_day = Convert.ToByte(Console.ReadLine());
if (n_day<1 || n_day>7) Console.WriteLine("такого дня не существует!"); 
    else {
        switch(n_day)
        {
            case 1: Console.WriteLine("понедельник - рабочий день");
            break;
            case 2: Console.WriteLine("вторник - рабочий день");
            break;
            case 3: Console.WriteLine("среда - самый, что ни на есть, рабочий день");
            break;
            case 4: Console.WriteLine("четверг - маленькая пятница");
            break;
            case 5: Console.WriteLine("пятница - еле-еле душа в теле");
            break;
            case 6: Console.WriteLine("суббота  - выходной, однако");
            break;
            case 7: Console.WriteLine("воскресенье  - сам Бог велел отдохнуть");
            break;
        }
    }
    
    
