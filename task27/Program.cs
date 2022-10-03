/*Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12*/
using static System.Console;
Clear();
Write("Введите число: ");
int num = Convert.ToInt32(ReadLine()!);
int sum = Sum(num);
WriteLine($"Сумма чисел в числе = {sum}");

int Sum(int num)
{
    if (num<10)
    return num;
    int numA = num%10;
    int numB = num/10;
    return numA + Sum(numB);
}