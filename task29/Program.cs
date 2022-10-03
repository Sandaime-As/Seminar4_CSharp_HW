/*Напишите метод, который формирует массив из 8 случайных элементов и выводит их на экран.

1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33]*/
using static System.Console;
Clear();

void FillArray(int[] Array)
{
    int length=Array.Length;
    int i=0;
    while (i<length)
    {
        Array[i] = new Random().Next(1, 100);
        i++;
    }
}
void PrintArray(int[] Array1)
{
    int num = Array1.Length;
    int index = 0;
    while (index<num)
    {
        WriteLine(Array1[index]);
        index++;
    }
}
int[] array = new int [8];

FillArray(array);
PrintArray(array);

// Кажется задание выполнено не по условию...

// int num = Convert.ToInt32(ReadLine()!);
// WriteLine($"(array = [{FillArray(array)}])");
// WriteLine($"(array = [{PrintArray(array)}])");