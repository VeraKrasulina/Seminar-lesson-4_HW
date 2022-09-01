// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// принимает на вход число
// выдаёт сумму цифр в числе

Console.Write ("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int NumbersSum (int number)
{
int num_st = number % 10;
int sum = 0;
while (number > 100)
{
    num_st = number % 10;
    number = number / 10;
    sum = sum + num_st;
}
sum = sum + (number/10) + (number % 10);
return (sum);
}

int result = NumbersSum (num);
Console.WriteLine ($"Сумма всех чисел числа - {result}.");