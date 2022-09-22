Console.Clear();
Console.Write("Введите номер дня недели: ");
int n;

while (true)
{
   n = Convert.ToInt32(Console.ReadLine());
   if (n > 0 && n < 8)
   {
      break;
   }
   Console.WriteLine("Ошибка. Попробуйте снова");
}
if (n == 6 || n == 7)
{
   Console.WriteLine("Этот день выходной");
   
}
else
{
   Console.WriteLine("Это будний день");
   }
