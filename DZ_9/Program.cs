//Напишите программу, которая принимает
//на вход координаты двух точек и находит расстояние
//между ними в 3D пространстве.

Console.Write("Введите координаты x1: ");
Double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y1: ");
Double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z1: ");
Double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты x2: ");
Double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y2: ");
Double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z2: ");
Double z2 = Convert.ToDouble(Console.ReadLine());

Double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
Console.ReadKey();