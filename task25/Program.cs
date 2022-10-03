/*Напишите метод, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B с использованием цикла.

3, 5 -> 243 (3⁵)
2, 4 -> 16*/
using static System.Console;
Clear();
Write("Введите число A: ");
int numA = Convert.ToInt32(ReadLine()!);
Write("Введите число B: ");
int numB = Convert.ToInt32(ReadLine()!);

int exponenta = GetExponenta(numA, numB);
WriteLine($"{numA} в натуральной степени {numB} = {exponenta}");
 
int GetExponenta(int numA, int numB)
{
  int result = 1;
  for(int i=1; i <= numB; 
  i++)
  {
    result = result * numA;
  }
    return result;
}