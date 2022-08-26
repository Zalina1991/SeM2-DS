//Console.WriteLine("Введите два числа: ");
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int a1 = run / 10;
//nt a2 = run % 10;
//int max = a1;
//if (max < a2);
//{
    //max = a2;
//}
//Console.WriteLine(max cifra v chisle "+ run + ");

//int num = new Random().Next(100, 1000);
//int a1 = num % 100;
//int a2 = num / 10;

//Console.WriteLine("Введите два числа: ");
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//number1 % number2
//if (number1 % number2 == 0)
//{  
  //  Console.WriteLine("Кратно");
//}
//else 
//{
  //  Console.WriteLine("Некратно, остаток от деления"  + number1 % number2);
//}
//Console.WriteLine("Число кратно 7 и 23 одновременно");
//if (number % 161 == 0)
//{
  //  Console.WriteLine("Число кратно 7 и 23 одновременно");
//}
//else
//{
 //   Console.WriteLine("Число некратно 7 и 23 одновременно");
///}


//Console.WriteLine("Введите два числа: ");
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//if (a == b * b)
//{
   // Console.WriteLine("a квадрат b");
//}
//else if (b == a * a)
//{
    //Console.WriteLine("b квадрат a");

//}
 //else 
 //{
   // Console.WriteLine("Не квадрат");
 //}


//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 //и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

/* Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
int a1 = a / 10;
int a2 = a1 % 100;
int a3 = a2 % 10;
int a4 = a3 % 100;
Console.WriteLine(a3); */


//Задача 13: Напишите программу, которая выводит
 //третью цифру заданного числа или сообщает, 
 //что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

/* Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
string number = a.ToString();
if (a < 100)
{
  Console.WriteLine(a + " -> Третьей цифры нет");
}
else if (a > 99)
{
  Console.WriteLine(a + " -> Вывести 3 цифру -> " + number[2]);
} */
 //Задача 15: Напишите программу, которая принимает на вход цифру,
  //обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

//Console.WriteLine("Введите номер дня: ");
//int day = int.Parse(Console.ReadLine());
//if (day > 7)
//{
 // Console.WriteLine("Повторите ввод");
//}
//if (day < 1)
//{
 // Console.WriteLine("Повторите ввод");
//}
//else if (day == 6)
//{
//Console.WriteLine("Да, это выходной день");
//}
//else if (day == 7)
//{
  //Console.WriteLine("Да, это выходной день");
/* }
else 
{
  Console.WriteLine("Нет, это не выходной день");
} */