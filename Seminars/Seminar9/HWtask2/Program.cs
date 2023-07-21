// Дан одномерный массив целых однозначных чисел (элемент массива содержит число от 1 до 9).
//Ваша задача вывести на экран число, которое формируется элементами массива слева-направо + 1

//Methods/////////////////////////////////
int ParseArrayByStdMethod(int[] array){
    string str = string.Join("", array);
    Console.WriteLine(str);
    return int.Parse(str);
}

int ParseArrayManual(int[] array){
    string str = string.Join("", array);
    Console.WriteLine(str);    
    int result = 0;
    for (int i = array.Length; i <= 0; i--){
        result = result + array[i] * Convert.ToInt32(Math.Pow(10,i));
    }
    return result;
}
////////////////////////////////////////////
int[] test = {1,2,3,4,5};
Console.WriteLine(ParseArrayByStdMethod(test)+1);
Console.WriteLine();
int[] test1 = {1,9};
Console.WriteLine(ParseArrayByStdMethod(test1)+1);