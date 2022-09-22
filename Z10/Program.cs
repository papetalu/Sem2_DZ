Console.Clear();
Console.Write("Введите трехзначное число: ");
int n;

while (true)
{
   n = Convert.ToInt32(Console.ReadLine());
   if (n >= 100 && n < 1000 || n >= -999 && n < -100)
   {
      break;
   }
   Console.WriteLine("Число не трехзначное. Попробуйте снова");
}
if (n > 0)
{
   int x = n % 100;
   int y = x / 10;
   Console.WriteLine("Вторая цифра числа: ");
   Console.WriteLine(y);
}
else
{
   int x = n % 100;
   int y = x / -10;
   Console.WriteLine("Вторая цифра числа: ");
   Console.WriteLine(y);
}