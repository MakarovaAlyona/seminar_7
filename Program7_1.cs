//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.


Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Натуральные числа в промежутке от {m}  до {n}:");

    PrintNumbers(m, n);

    Console.ReadKey();


static void PrintNumbers(int m, int n)
{
    if (m == n)
        Console.Write(m + " ");
    else
    {
        PrintNumbers(m, n - 1);
        Console.Write(n + " ");
    }
}



