// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива

//Methods////////////////////////
double[] DefRealArray(int size)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
        array[i] = Convert.ToDouble(new Random().Next(-100, 101)) / Convert.ToDouble(new Random().Next(1, 11));

    var str = string.Join(";  ", array);
    Console.WriteLine(str);

    return array;

}
/////////////////////////////////

double[] testArray = DefRealArray(5);

//double result = testArray.Max() - testArray.Min();

Console.WriteLine("Max - Min = " + (testArray.Max() - testArray.Min()));