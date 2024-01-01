// -----------------------------------------------------------------------
// ЗАДАЧА 1

// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

Console.Clear();


Console.Write("Введите размер матрицы (два числа через пробел): ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); 
int[,] matrix = new int[size[0], size[1]];
Console.Write("Введите позиции элемента в массиве (два числа через пробел): ");
int[] PosNumbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.Write($"({string.Join(", ", PosNumbers)}) => ");
ReleaseMatrix(matrix);


// Функция заполняет матрицу:
void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 101); //[0;100]
}


// Функция осуществляет вывод матрицы:
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}


// Функция осуществляет проверку наличия элемента,
// соответствующего указанным пользователем позициям,
// и при наличии такого элемента возвращает True, иначе - False:
bool CheckMatrix(int[,] matrix)
{
    if ((PosNumbers[0] > matrix.GetLength(0) - 1) || (PosNumbers[1] > matrix.GetLength(1) - 1))
        return false;
    return true;
}


// Функция возвращает элемент,
// соответствующий указанным пользователем позициям,
// или выводит сообщение о его отсутствии:
void ReleaseMatrix(int[,] matrix)
{
    if (CheckMatrix(matrix) == false)
        Console.Write("Такого элемента нет в массиве");
    else
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == PosNumbers[0] && j == PosNumbers[1])
                {
                Console.Write(matrix[i, j]);
                break;
                }
            }
        }    
    } 
}


// -----------------------------------------------------------------------




// -----------------------------------------------------------------------
// ЗАДАЧА 2

// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

Console.Clear();

Console.Write("Введите размер матрицы (два числа через пробел): ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); 
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("=>");
Console.WriteLine();
ReleaseMatrix(matrix);


// Функция заполняет матрицу:
void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 101); //[0;100]
}


// Функция осуществляет вывод матрицы:
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}


// Функция осуществляет перемену местами 
// первой и последней строки массива:
void ReleaseMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
                Console.Write(matrix[matrix.GetLength(0) -1 , j] + "\t");
            else if (i == matrix.GetLength(0) - 1)
                Console.Write(matrix[0, j] + "\t");
            else
                Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


// -----------------------------------------------------------------------




// -----------------------------------------------------------------------
// ЗАДАЧА 3

// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

Console.Clear();


Console.Write("Введите размер матрицы (два числа через пробел): ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); 
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.Write("=> ");
ReleaseMatrix(matrix);


// Функция заполняет матрицу:
void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 101); //[0;100]
}


// Функция осуществляет вывод матрицы:
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}


// Функция выявляет индекс строки с наименьшей суммой элементов:
void ReleaseMatrix(int[,] matrix)
{
    int[] sums = new int[matrix.GetLength(0)];
    int Sum;

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        Sum = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Sum += matrix[i,j];
        }
        sums[i] = Sum;
    }

        Console.WriteLine($"Суммы строк: [{string.Join(", ", sums)}]");

    int MinSum = sums[0];
    int MinIdx = 0;

    for(int i = 0; i < sums.Length; i++)
    {
        if (sums[i] < MinSum)
        {
            MinSum = sums[i];
            MinIdx = i;
        }
    }
            
    Console.WriteLine($"=> Наименьшая сумма элементов, равная {MinSum}, - в строке в индексом {MinIdx}");
}
        

// -----------------------------------------------------------------------




// -----------------------------------------------------------------------
// ЗАДАЧА 4* (не обязательная)

// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива 
// без строки и столбца.

Console.Clear();


Console.Write("Введите размер матрицы (два числа через пробел): ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); 
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
FindMinIdx(matrix);
ReleaseMatrix(matrix);


// Функция заполняет матрицу:
void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 101); //[0;100]
}


// Функция осуществляет вывод матрицы:
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}


// Функция определяет индексы для наименьшего элемента массива:
int[] FindMinIdx(int[,] matrix)
{
    int MinEl = matrix[0, 0];

    int[] MinIdx = new int[2];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < MinEl)
            {
                MinEl = matrix[i, j];
                MinIdx[0] = i;
                MinIdx[1] = j;
            }
        }
    }
    return MinIdx;
}


// Функция выводит новый массив, в котором удалены строка и столбец, 
// на пересечении которых расположен наименьший элемент 
// изначального массива:
void ReleaseMatrix(int[,] matrix)
{
    int[] FoundMinIdx = FindMinIdx(matrix);

    Console.WriteLine($"=> Наименьший элемент массива равен {matrix[FoundMinIdx[0],FoundMinIdx[1]]}");
    Console.WriteLine();
    Console.WriteLine("=> Новый массив после удаления строки и столбца:");

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if((i == FoundMinIdx[0]) || (j == FoundMinIdx[1]))
                continue;
            else
                Console.Write(matrix[i, j] + "\t");
        }
            
        if (i != FoundMinIdx[0])
            Console.WriteLine();
    }
}

// -----------------------------------------------------------------------
// -----------------------------------------------------------------------