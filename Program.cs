Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int a1 = a / 100;
//int a1 = - 1;
if (a1 <= 3)
{
  Console.WriteLine("Третьей цифры нет");
}
 int a2 = a % 100;
 int a3 = a2 % 10;
 if (a >= 3)
{
    Console.WriteLine("Вывести 3 цифру: " + a3);
}


 /* Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
string a = a;
int a1 = a % 10;
//(a1 / 10);
//->
Console.WriteLine("Вывести 3 цифру: " + a1);

if (a < 100)
//else
{
  Console.WriteLine("Третьей цифры нет");
} */

