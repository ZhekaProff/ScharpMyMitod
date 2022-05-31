// Методы Oдномерный массив

void FillArray(int[] array) // заполняем массив рандомными числами 
{
    for(int i = 0; i < array.Length; i++ )
    {
        array[i] = new Random().Next(1, 10);     
    }
}

void PrintArray(int[] array) // функция печати массива
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

// Двумерный массив

void FillMatrix( int[,] matrix) // Заполняем рандомными числами
{
    for ( int  i = 0; i < matrix.GetLength(0); i++)
    {
        for ( int j = 0; j < matrix.GetLength(1) ; j++)
        {
            matrix[i, j] = new Random().Next(1,10); 
        }
    
    }


}

void PrintMatrix(int [,] matrix) // функция печати матрицы
{
    for ( int  i = 0; i < matrix.GetLength(0); i++)
    {
        for ( int j = 0; j < matrix.GetLength(1) ; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

// Ввод данных Oдномерный массив

Console.Write("Введите число элементов массива: ");
int n = int.Parse(Console.ReadLine() ?? "0"); 
int [] array = new int[n]; 

// Ввод данных Двумерный массив

Console.Write("Введите число строк: ");
int i = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов: ");
int j = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[i, j];