// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int summa = 0;
while (n > 0)
{
    summa = summa + n % 10;
    n /= 10;
}
Console.Write("Сумма: " + summa);
