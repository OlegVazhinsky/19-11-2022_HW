/*

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

*/

int GetNumber (string message) {
    int userNumber;
    while (true) {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out int number) && number >= 0) {
            userNumber = number;
            break;
        }    
        else {
            Console.WriteLine($"{number} не соответствует, повторите ввод.");
        }
    } 
    return userNumber;
}

double[,] InitArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = rnd.NextDouble() * 10;
        }
    }
    return array;
}

void PrintElementInArray(int m, int n, double [,] array)
{
    if (m > array.GetLength(0)) {
        Console.WriteLine($"Массив имеет меньше строк, чем {m}.");
    }
    else if (n > array.GetLength(1)) {
        Console.WriteLine($"Массив имеет меньше столбцов, чем {n}.");
    }
    else {
        Console.WriteLine($"Элемент на строке {m} и столбце {n} равен {Math.Round(array[m, n], 2)}.");
    }
    
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{Math.Round(array[i, j], 2)} ");
        }
        Console.WriteLine();
    }
    
}

int m = GetNumber("Введите строку, где находится элемент массива - ");
int n = GetNumber("Введите столбец, где находится элемент массива - ");
double[,] myArray = InitArray(6,6);
PrintArray(myArray);
Console.WriteLine();
PrintElementInArray(m, n, myArray);
