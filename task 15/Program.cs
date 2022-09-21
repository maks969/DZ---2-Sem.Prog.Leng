// Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели");
int x = int.Parse(Console.ReadLine());

if (x == 1) Console.WriteLine("понедельник");

else if (x == 2) Console.WriteLine("вторник");

else if (x == 3) Console.WriteLine("среда");

else if (x == 4) Console.WriteLine("четверг");

else if (x == 5) Console.WriteLine("пятница");

else if (x == 6) Console.WriteLine("суббота");

else if (x == 7) Console.WriteLine("воскресенье");


else
{
    Console.WriteLine("проверьте правильность ввода");
}