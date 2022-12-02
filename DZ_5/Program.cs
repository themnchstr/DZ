//Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает вторую цифру этого
//числа.

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

int Number2nd = (number/10) % 10;

Console.WriteLine($"Второе число {Number2nd}");