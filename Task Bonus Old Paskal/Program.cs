//построить треугольник паскаля с указанной высотой 






//      1
//     1 1
//    1 2 1
//   1 3 3 1 
//  1 4 6 4 1


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            System.Console.Write("{0,4:F0}", (inArray[i, j] > 0) ? (inArray[i, j]) : (" "));
        }
        Console.WriteLine();
    }
}

void Main()
{
    System.Console.Write("Введите высоты пирамиды: ");
    int hight = Convert.ToInt32(Console.ReadLine()!);
    //int start = 0;

    int width = 2 * hight + 1;  // должно быть 2*hight-1, но я специально добавил +1
                                // чтобы потом не проверять на выход за границы влево или вправо 

    int[,] arr = new int[hight, width];

    for (int h = 0; h < hight; h++)
    {
        for (int w = 0; w < width; w++)
        {
            if (h == 0)
            {
                arr[h, width / 2] = 1;
            }
            else
            {
                if (w > 0 && w < width - 1)
                    arr[h, w] = arr[h - 1, w - 1] + arr[h - 1, w + 1];
            }
        }
    }
    PrintArray(arr);
}

Main();