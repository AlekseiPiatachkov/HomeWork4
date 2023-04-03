
/* Задача 27: Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.Write($"{number} -> {GetSumArray(number)}");

int GetSumArray(int number)
{
    int i = 0;
    int sum = 0;
    while (number > 10)
    {
        sum = number % 10 + sum;
        number = number / 10;
        i++;
    }
    sum = number + sum;
    return sum;
}
