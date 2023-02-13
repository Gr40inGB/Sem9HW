// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string RankToOne(int n)
{
    if (n == 1) return 1.ToString();
    else return n.ToString() + ", " + RankToOne(n - 1);
}

void Main()
{
    System.Console.Write("Программа выведет все натуральные числа в промежутке от указанного числа до 1.\nВведите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine(RankToOne(number));
}

Main();