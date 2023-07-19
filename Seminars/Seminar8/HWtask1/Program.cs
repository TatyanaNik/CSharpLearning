//Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

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

void SortEachRowByChoice(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++){
            int maxElement = matrix[i,j];
            int maxElementIndex = j;
            for(int k = j+1; k < matrix.GetLength(1); k++){
                if (matrix[i,k]>maxElement){
                    maxElement = matrix[i,k];
                    maxElementIndex = k;
                }
            }
            matrix[i,maxElementIndex] = matrix[i,j];
            matrix[i,j] = maxElement;
        }       
    }
}
///////////////////////////////////////////////
int[,] testArray = FillIntMatrix(3, 7);
Print2dIntMatrix(testArray);
Console.WriteLine();
SortEachRowByChoice(testArray);
Print2dIntMatrix(testArray);