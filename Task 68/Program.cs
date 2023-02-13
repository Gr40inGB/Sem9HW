// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

void Main()
{
    System.Console.Write("Программа вычислит функцию Аккрмана с заданными M и N .\nВведите число M: ");
    uint numberM = Convert.ToUInt32(Console.ReadLine());
    System.Console.Write("Введите число N: ");
    uint numberN = Convert.ToUInt32(Console.ReadLine());

    System.Console.WriteLine($"Akerman({numberM} , {numberN}) = {Akkerman(numberM, numberN)}");
}

uint Akkerman(uint m, uint n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

Main();