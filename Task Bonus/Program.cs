// Задача со звездочкой: Пользователь вводит скобочные последовательности.
//  В последовательности могут встретиться скобки вида: {}, (), [].
// Правильная скобочная последовательность - символьная последовательность, 
// составленная в алфавите, состоящем из символов, сгруппированных в упорядоченные пары.
// Пример правильной скобочной последовательности: (), ()[]{}
// Пример неправильной: (], ({)}
// Написать программу, которая определяет правильная ли скобочная последовательность была введена

bool CheckStartEnd(string s)
{
    Stack<string> startEnd = new Stack<string>();
    foreach (var symb in s)
    {
        if (symb == '(' || symb == '{' || symb == '[')
        {
            startEnd.Push(symb.ToString());
        }

        else if (symb == ')' || symb == '}' || symb == ']')
        {
            if (startEnd.TryPeek(out var startSymb))
            {
                string tempStr = startSymb.ToString() + symb.ToString();
                if (tempStr == "()" || tempStr == "{}" || tempStr == "[]")
                {
                    startEnd.Pop();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }

    if (startEnd.Count == 0) return true;
    else return false;

}

void Main()
{
    System.Console.WriteLine("Введите строку для анализа расположений скобок");

    string stringForCheck = Console.ReadLine()!;
    bool checkOk = CheckStartEnd(stringForCheck);
    if (checkOk) System.Console.WriteLine("Ряд верен");
    else System.Console.WriteLine("Ряд неверен");

}

Main();