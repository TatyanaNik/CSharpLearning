// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//Methods//////////////////////////////////
double[,] FillDoubleMatrix(int m, int n){
    double[,] matrix = new double[m,n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            matrix[i,j] =  Convert.ToDouble(new Random().Next(-100,100))/(new Random().Next(1,100));
        }
    }
    return matrix;
}

void Print2dDoubleMatrix(double[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write(string.Format("{0,8:0.00}", matrix[i,j]));
        }
        Console.WriteLine();
    }
}
/////////////////////////////////////////////

Print2dDoubleMatrix(FillDoubleMatrix(5,3));
