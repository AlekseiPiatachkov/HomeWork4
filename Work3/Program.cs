/* Задача 29: Напишите программу, которая задаёт массив из 8 
элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Console.WriteLine("Введите весемь элементов массива: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
int e = int.Parse(Console.ReadLine());
int f = int.Parse(Console.ReadLine());
int g = int.Parse(Console.ReadLine());
int h = int.Parse(Console.ReadLine());

int[] arr = { a, b, c, d, e, f, g, h };
int count = arr.Length;

Console.Write($"{a}, {b}, {c}, {d}, {e}, {f}, {g}, {h} -> ");

PrintArray(arr);

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
            Console.Write($" {col[position]} ");
        position++;
    }
}