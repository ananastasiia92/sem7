// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся
//  на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное число в массиве: ");
int max = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное число в массиве: ");
int min = int.Parse(Console.ReadLine());

int[,] arr = GetArray(m,n,min,max);
int sum = FindSum(arr);

PrintArray(arr);
Console.WriteLine();
Console.WriteLine(sum);

int[,] GetArray(int m,int n,int min,int max){
    int[,] array = new int[m,n];

    for(int i = 0;i < m;i++){
        for(int j = 0;j < n;j++){
            array[i,j] = new Random().Next(min,max + 1);
        }
    }
    return array;
}

int FindSum(int[,] arr){
    int sum = 0;
    for(int i = 0;i < arr.GetLength(0);i++){
        sum += arr[i,i];
    }
    return sum;
}

void PrintArray(int[,] arr){
    for(int i = 0;i < arr.GetLength(0);i++){
        for(int j = 0;j < arr.GetLength(1);j++){
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}
 
/*
int FindSum(int[,] arr){
    int sum = 0;
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    int size = 0;

    if(m > n){
        size = n;
    }
    else{
        size = m;
    }
    for(int i = 0;i < size;i++){
        sum += arr[i,i];
    }
    return sum;
}
*/