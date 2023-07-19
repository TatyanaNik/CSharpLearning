//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
//Methods//////////////////////////////////
int[,] FillIntMatrix(int m, int n){
    int[,] matrix = new int[m,n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            matrix[i,j] =  new Random().Next(0,10);
        }
    }
    return matrix;
}

void Print2dIntMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write(string.Format("{0,5}", matrix[i,j]));
        }
        Console.WriteLine();
    }
}

int[,] ProductMatrix(int[,] A, int[,] B){
    if (A.GetLength(1) != B.GetLength(0)){
        Console.WriteLine("Incorrect data");
        Environment.Exit(0);
    }

    int[,] C = new int[A.GetLength(0), B.GetLength(1)];

    for (int i = 0; i < A.GetLength(0); i++){
        for(int j = 0; j < B.GetLength(1); j++){
            for (int r = 0; r < A.GetLength(1); r++){
                C[i,j] = C[i,j] + A[i,r]*B[r,j];
            }
        }
    }

    return C; 
}

//////////////////////////////////////////////////
int[,] matrixA = FillIntMatrix(1, 2);
Print2dIntMatrix(matrixA);
Console.WriteLine();

int[,] matrixB = FillIntMatrix(2, 3);
Print2dIntMatrix(matrixB);
Console.WriteLine();

int[,] resultArray = ProductMatrix(matrixA, matrixB);
Print2dIntMatrix(resultArray);