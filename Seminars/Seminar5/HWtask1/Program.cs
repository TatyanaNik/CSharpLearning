//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
//Methods//////////////////////////////////

int CalcEvenOddNum(bool type, int[] array)
{
    //type = false - calc summ of even numbers
    //type = true - calc summ of odd numbers

int sum = 0;
    if (type)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                sum ++;
            }
        }
    }else{
         for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                sum ++;
            }
        }       
    }
    return sum;
}
///////////////////////////////////////////
int size = 4;

int[] array = new int[size];

Console.Write("Исходный массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(" " + array[i]);
}

Console.WriteLine();


Console.WriteLine("Количество четных: " + CalcEvenOddNum(false,array));
