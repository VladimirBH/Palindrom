// string str = Console.ReadLine();
// bool isPalindrom = true;
// for(int first = 0, last = str.Length - 1; first < last; first++, last--)
// {
//     if(str[first] != str[last])
//     {
//         isPalindrom = false;
//     }
// }
// if(isPalindrom)
// {
//     Console.WriteLine("Слово является палиндромом");
// }
// else
// {
//     Console.WriteLine("Слово не является палиндромом");
// }

// Console.WriteLine("Введите количество элементов массива: ");
// int count = Convert.ToInt32(Console.ReadLine());
// int[] intArr = new int[count];

// for (int i = 0; i < count; i++)
// {
//     intArr[i] = Convert.ToInt32(Console.ReadLine());
// }



int count = 5;
int[,] matrix = new int[count,count];

Random random= new();
for(int i = 0; i < count; i++)
{
    for(int j = 0; j < count; j++)
    {
        matrix[i,j] = random.Next(1, 100);
    }
    Console.WriteLine();
}

PrintMatrix(matrix);

for(int i = 0; i < count; i++)
{
    for(int j = i; j < count; j++)
    {
        int temp = matrix[i,j];
        matrix[i,j] = matrix[j,i];
        matrix[j,i] = temp;
    }
}

PrintMatrix(matrix);

void PrintMatrix(int[,] mat)
{
    for(int i = 0; i < count; i++)
    {
        for(int j = 0; j < count; j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
}

