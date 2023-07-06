//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 


int[] array = new int[123];


for (int i = 0; i < array.Length; i++)
     {
         array[i] = new Random().Next(0, 1000);
         Console.Write(" " + array[i]);
     }

Console.WriteLine();
int sum = 0;

for (int i = 0; i < array.Length; i++){
    if (array[i]<=99 && array[i]>=10){
        sum++;
    }
}

Console.WriteLine(sum);