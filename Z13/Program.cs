Console.Clear();
string a = Convert.ToString(new Random().Next(0, 10000));
if (a.Length >2)
{
Console.Write("Число выбрано - " + a + ", третья цифра - ");
Console.WriteLine(a[2]);
}
else
{
   Console.Write("Число выбрано - " + a + ", третьей цифры нет");

}