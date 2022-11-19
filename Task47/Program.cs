/*

Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

*/

int GetNumber (string message) {
    int userNumber;
    while (true) {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out int number) && number > 0) {
            userNumber = number;
            break;
        }    
        else {
            Console.WriteLine($"{number} не является числом, повторите ввод.");
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

int n = GetNumber("Введите количество строк массива - ");
int m = GetNumber("Введите количество столбцов массива - ");
double[,] myArray = InitArray(n,m);
PrintArray(myArray);
