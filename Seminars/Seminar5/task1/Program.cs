
//Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] array = { -4, -8, 8, 2 };

var str = string.Join(",", array);
Console.WriteLine(str);

for (int i = 0; i < array.Length; i++){
    array[i] = -1 * array[i]; 
}

str = string.Join(",", array);
Console.WriteLine(str);
