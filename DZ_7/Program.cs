//Напишите программу, которая принимает на вход
//цифру, обозначающую день недели, и проверяет, является ли
//этот день выходным.

Console.WriteLine("Enter day number : ");
string enterDay = Console.ReadLine();
int day = Convert.ToInt32(enterDay);
string WeekDay = "Monday";

if (day == 1 ) WeekDay = "No";
if (day == 2 ) WeekDay = "No";
if (day == 3 ) WeekDay = "No";
if (day == 4 ) WeekDay = "No";
if (day == 5 ) WeekDay = "No";
if (day == 6 ) WeekDay = "Yes";
if (day == 7 ) WeekDay = "Yes";

Console.WriteLine(WeekDay);
