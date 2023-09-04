/*Console.Write("Enter nember = ");
string strNum = Console.ReadLine(); /*789
int num = int.Parse(strNum); /*789
int sqr = num * num;
Console.WriteLine(sqr);

//*Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет*/


Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
if(numB * numB == numA) {
    Console.WriteLine("Да!");
} else {
    Console.WriteLine("Нет!");
}
//Решение студентов
//

Console.WriteLine("Введите число №1: ");
string strNum1 = Console.ReadLine();
int Num1 = int.Parse(strNum1);
Console.WriteLine("Введите число №2: ");
string strNum2 = Console.ReadLine();
int Num2 = Convert.ToInt32(strNum2);
int sqr2 = Num2 * Num2;
if(Num1 == sqr2)
{
    Console.WriteLine("Правда");
}
else
{
    Console.WriteLine("Фигня");
}

/*Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница*/

Console.WriteLine("Введи день недели цифрой: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

if (dayWeek == 1)
{ Console.WriteLine("Сегодня Понедельник"); }
else if (dayWeek == 2)
{ Console.WriteLine("Сегодня Вторник"); }
else if (dayWeek == 3)
{ Console.WriteLine("Сегодня Среда"); }
else if (dayWeek == 4)
{ Console.WriteLine("Сегодня Четверг"); }
else if (dayWeek == 5)
{ Console.WriteLine("Сегодня Пятница"); }
else if (dayWeek == 6)
{ Console.WriteLine("Сегодня Суббота"); }
else if (dayWeek == 7)
{ Console.WriteLine("Сегодня Воскресенье"); }
else
{ Console.WriteLine("введи от 1 до 7"); }  


 /*Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"*/
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numNew = -num;
for (int i = -num; i < num; i++) 
{    
    numNew = numNew + 1;
    Console.Write(numNew);
    Console.Write(", ");
}
/*

/*Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8*/    
    Console.Write("Enter a namber: " );
num = Covert.ToInt32(Console.ReadLine());
if (num >99 && num < 1000)
{ 
    int newNum = num %10;
    Console.WriteLine(newNum);
}
else
{ 
    Console.WriteLine("Incorrect number!");
}