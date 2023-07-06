// Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве

int[] calcProd(int[] array){
    int size;

    if (array.Length % 2 == 0) {
        size = array.Length/2;
    }else{
        size = array.Length/2 + 1;
    }

    int[] result = new int[size];

    for(int i =0; i < array.Length/2; i++){
        result[i] = array[i] * array[array.Length -1 -i];
    }

    if (array.Length % 2 != 0) {
        result[size - 1] = array[array.Length/2];
    }

    return result;
} 


int[] array1 = { 1, 2, 3, 4 };
var str = string.Join(",", calcProd(array1));
Console.WriteLine(str);

int[] array2 = { 1, 2, 5, 3, 5, 1, 2 };
str = string.Join(",", calcProd(array2));
Console.WriteLine(str);
