Console.WriteLine("vvedite chislo");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int Line(int sum)
{
  if(sum == 0) return 0;
  else 
  {
    //int temp = 0;
    sum = sum%10 + Line(sum/10);

  }
  return sum;
   

}
Console.WriteLine(Line(num));