/* Задача 25: Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine());

Console.Write(Exponention(A, B));

int Exponention(int A, int B)
{
    int i = 1;
    int result = 0;
    while (B > i)
    {
        if (i == 1) result = A * A;
        else result = A * result;
        i++;
    }
    return result;
}