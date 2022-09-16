/*Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.*/

//положительное число не больше 8ми знаков

Console.WriteLine("Введите число");
int c = int.Parse(Console.ReadLine()!);

int x = c;
int[] a = new int[x.ToString().Length];
for (int i = 0; i<a.Length; i++)
{
   a[i] = x % 10;
   x /=10;
}
Array.Reverse(a);

if (a.Length>=2) 
{
   Console.WriteLine(a[2]);
}
else
{
   Console.WriteLine("У ЭТОГО ЧИСЛА НЕТ ТРЕТЬЕЙ ЦИФРЫ!");
}

