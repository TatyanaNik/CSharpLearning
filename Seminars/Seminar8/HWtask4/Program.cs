//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//Methods//////////////////////////////////
int[,,] Fill3dIntMatrix(int m, int n, int l)
{

    if (m * n * l >= 100)
    {
        Console.WriteLine("Невозможно подобрать неповторяющиеся двузначные числа.");
        Environment.Exit(0);
    }

    int[,,] matrix = new int[m, n, l];

    Dictionary<int, int> numbs = new Dictionary<int, int>();

    for (int i = 0; i < m * n * l; i++)
    {
        int newElement = new Random().Next(10, 100);
        while (numbs.ContainsValue(newElement))
        {
            newElement = new Random().Next(10, 100);
        }
        numbs[i] = newElement;
    }
    int key = 0;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                key = i*n*l + j*l + k;
                matrix[i, j, k] = numbs[key];
            }

        }
    }

    return matrix;
}

void Print3dIntMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(string.Format("{0,12}", matrix[i, j, k] + $"({i};{j};{k})"));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
//////////////////////////////////////////////

Print3dIntMatrix(Fill3dIntMatrix(2, 2, 2));