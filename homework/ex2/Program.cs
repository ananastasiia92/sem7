//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/


Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 20);

PrintArray(array);

if(NumberSearch(array, N))
{
    Console.WriteLine("Элемент найден");
}
else
{
    Console.WriteLine("Элемент не найден");
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        
return result;
}
bool NumberSearch(int[, ] array, int A)
{
    for(int i = 0;i < array.GetLength(0);i++){
        for(int j = 0;j < array.GetLength(1);j++){
            if (array[i, j] == A){
                return true;
            }
        } 
    }               
    return false;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
