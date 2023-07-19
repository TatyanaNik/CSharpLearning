// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов

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
            Console.Write(string.Format("{0,8}", matrix[i,j]));
        }
        Console.WriteLine();
    }
}

int FindRowWithMinSumm (int[,] matrix){
    int minRowSumm = int.MaxValue;
    int rowN = 0;
    
    for (int i = 0; i < matrix.GetLength(0); i++){
        int tmpRowSumm = 0;
        for (int j = 0; j < matrix.GetLength(1); j++){
            tmpRowSumm = tmpRowSumm + matrix[i,j];
        }       
        if (tmpRowSumm < minRowSumm){
            minRowSumm = tmpRowSumm;
            rowN = i;
        }
    }  
    return rowN;  
}
/////////////////////////////////////////////////////////////
int[,] testArray = FillIntMatrix(3, 2);
Print2dIntMatrix(testArray);
Console.WriteLine();
Console.WriteLine("Строка с минимальной суммой элементов:" + FindRowWithMinSumm(testArray));
