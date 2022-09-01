// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// принимает на вход число
// выдаёт сумму цифр в числе

Console.Write ("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int num_st = num % 10;
int sum = 0;

while (num > 100)
{
    num_st = num % 10;
    num = num / 10;
    sum = sum + num_st;
}
sum = sum + (num/10) + (num % 10);

Console.WriteLine ($"Сумма всех чисел числа - {sum}.");