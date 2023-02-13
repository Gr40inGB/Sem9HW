// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов
//  в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Main()
{
    System.Console.Write("Программа найдёт сумму натуральных элементов от A до B.\nВведите число A: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите число B: ");
    int numberB = Convert.ToInt32(Console.ReadLine());

    if (numberA > numberB)
    {
        int temp = numberB;
        numberB = numberA;
        numberA = temp;
    }
    System.Console.WriteLine($"Сумма всех чисел от {numberA} до {numberB} равна {SummInterval(numberA, numberB)}");
}

int SummInterval(int a, int b)
{
    if (a == b) return b;
    else
    {
        return a + SummInterval(a + 1, b);
    }
}

Main();