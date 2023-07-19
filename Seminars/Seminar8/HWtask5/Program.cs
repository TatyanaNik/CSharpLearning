// Напишите программу, которая заполнит спирально массив 4 на 4

//Methods//////////////////////////////////

void Print2dIntMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write(string.Format("{0,5}", matrix[i,j]));
        }
        Console.WriteLine();
    }
}


int[,] FillMatrixBySpiral(int nRows, int nCols){
    int[,] matrix = new int[nRows, nCols];
    int minDimension =  Math.Min(nRows,nCols);
    int lastLoop = (minDimension%2 == 0) ? minDimension/2 : 1 + minDimension/2;
    int maxIndex = nRows*nCols;

    int index = 0;

    for(int loop = 0; loop < lastLoop; loop ++){
        //each loop inside previous
        int upRow       = loop;
        int rightColumn = nCols - 1 - loop;
        int downRow     = nRows - 1 - loop;
        int leftColumn  = loop;

        //fill up row
        for (int i = loop; i <= rightColumn; i++){            
            matrix[upRow,i] = index;
            index++;
            if(index == maxIndex) return matrix;
        }
        //fill right column
        for (int i = loop + 1; i < downRow; i++){
            matrix[i,rightColumn] = index;
            index++;
            if(index == maxIndex) return matrix;
        }
        //fill down row
        for (int i = rightColumn; i > leftColumn; i--){
            matrix[downRow,i] = index;
            index++;
            if(index == maxIndex) return matrix;
        }
        //fill left column
        for (int i = downRow; i > upRow; i--){
            matrix[i,leftColumn] = index;
            index++;
            if(index == maxIndex) return matrix;
        }
    }
    return matrix;
}

///////////////////////////////////////////////////////////
Print2dIntMatrix(FillMatrixBySpiral(4,3));