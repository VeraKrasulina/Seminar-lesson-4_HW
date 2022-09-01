// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// принимает на вход два числа (A и B)
// возводит число A в натуральную степень B.
Console.Write ("Введите число, которое возводим в степень: ");
double numA = double.Parse(Console.ReadLine()!);
Console.Write ("Введите степень, в которую мы возводим первое число: ");
double numB = double.Parse(Console.ReadLine()!);

double result = Math.Pow(numA, numB);
string res = string.Format("{0:F2}", result);
Console.WriteLine ($"{numA} в степени {numB} равняется {res}.");