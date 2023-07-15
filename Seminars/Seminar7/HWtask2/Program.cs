// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

string GetElementByPosition(int m, int n, int[,] matrix){
    string str = string.Empty;
    if (m < matrix.GetLength(0)
    && n < matrix.GetLength(1)){
        str = string.Format("{0,5}",matrix[m,n]);
    }else{
        str = "Элемента не существует.";
    }
    return str;
}
/////////////////////////////////////////////

int[,] randomMatrix = FillIntMatrix(3, 5);
Print2dIntMatrix(randomMatrix);

int m = 2; //user row number
int n = 1; //user column number

Console.WriteLine($"Элемент на позиции ({m},{n}): " + GetElementByPosition(m,n,randomMatrix));

