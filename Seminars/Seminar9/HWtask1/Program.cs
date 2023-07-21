//Дан одномерный массив целых чисел, элементом которого, может быть либо 1, либо 0.
//Ваша задача вывести на экран максимальное количество следующих друг за другом 1

//Methods/////////////////////////////////////////////////
int Calc1OneByOne(int[] array){
    int summ1 = 0;
    int maxSumm = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] == 1){
            summ1++;
        }else{
            if (summ1 > maxSumm) maxSumm = summ1;
            summ1 = 0;
        }
    }
    return Math.Max(summ1, maxSumm) > 1 ? Math.Max(summ1, maxSumm) : 0;
}
///////////////////////////////////////////////////////////////

int[] testArray = {0,0,0,1,1,0,1,1,1};

string str = string.Join("", testArray);

Console.WriteLine($"исходный массив: {str}, максимальное количество единиц подряд: {Calc1OneByOne(testArray)}");
