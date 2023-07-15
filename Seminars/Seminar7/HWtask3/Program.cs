// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
//Methods//////////////////////////////////
int[,] FillIntMatrix(int m, int n){
    int[,] matrix = new int[m,n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            matrix[i,j] =  new Random().Next(-100,100);
        }
    }
    return matrix;
}

void Print2dIntMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write(string.Format("{0,8}", matrix[i,j]));
        }
        Console.WriteLine();
    }
}

void PrintColumnMean(int[,] matrix){
    Console.WriteLine();
    Console.WriteLine("Средние по столбцам:");
    double[] mean = new double[matrix.GetLength(1)];
    
    for (int i = 0; i < matrix.GetLength(1); i++){
        int summ = 0;
        for (int j = 0; j < matrix.GetLength(0); j++){
            summ = summ + matrix[j,i];
        }
        mean[i] = Convert.ToDouble(summ)/matrix.GetLength(0);
        Console.Write(string.Format("{0,8}", mean[i]));
    }    
}
////////////////////////////////////////////////////////////////

int[,] randomMatrix = FillIntMatrix(2,3);
Print2dIntMatrix(randomMatrix);
PrintColumnMean(randomMatrix);