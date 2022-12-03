//Напишите программу, которая выводит третью
//цифру заданного числа или сообщает,
//что третьей цифры нет.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int Num = number/10;
int Num1 = number/100;

while (Num > 1000)
{
    Num = Num / 10;
}
if (Num1 == 0)
{
   Console.WriteLine("Третьего числа нет");
}
else if (Num > 100)
{
    Num = Num % 10;
    Console.WriteLine($"Третье число {Num}");
}
else
{
    Num = number % 10;
    Console.WriteLine($"Третье число {Num}");
}
