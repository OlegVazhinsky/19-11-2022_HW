/*

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            Console.WriteLine($"{number} не соответствует, повторите ввод.");
        }
    } 
    return userNumber;
}

int[,] InitArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = rnd.Next(0,11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    
}

double SumOfElementsInCol (int col, int[,] array) {
    double answer = 0;
    for (int i = 0; i < array.GetLength(0); i++) {
        answer += array[i, col];
    }
    return answer / array.GetLength(0);
}

int row = GetNumber("Введите количество строк массива - ");
int col = GetNumber("Введите количество столбцов массива - ");

int[,] myArray = InitArray(row, col);

PrintArray(myArray);
Console.WriteLine();

for (int i = 0; i < myArray.GetLength(1); i++) {
    Console.Write($"{SumOfElementsInCol(i , myArray)} ");
}
