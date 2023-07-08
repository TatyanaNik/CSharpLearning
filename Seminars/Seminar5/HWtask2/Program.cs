//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//Methods//////////////////////////////////

int CalcEvenOddPosNum(bool type, int[] array)
{
    //type = false - calc summ of even numbers
    //type = true - calc summ of odd numbers

int sum = 0;
    if (type)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
            {
                sum += array[i];
            }
        }
    }else{
         for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                sum += array[i];
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
    array[i] = new Random().Next(-100, 101);
    Console.Write(" " + array[i]);
}

Console.WriteLine();


Console.WriteLine("Сумма на нечетных позициях: " + CalcEvenOddPosNum(true,array));
