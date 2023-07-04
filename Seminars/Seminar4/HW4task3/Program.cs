// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int GetIntFromConsole()
{    
    string NumStr = Console.ReadLine();

    int x = 0;
    while (!(int.TryParse(NumStr, out x)))
    {
        Console.WriteLine("Некорректный ввод");
        Console.Write("Попробуйте еще раз: ");
        NumStr = Console.ReadLine();
    }
    return x;
}


Console.Write("Введите размер массива: ");
int arraySize = GetIntFromConsole();

int[] randArray = new int[arraySize];

Random rnd = new Random();

for (int i = 0; i < arraySize; i++){
    randArray[i] = rnd.Next();
} 

var str = string.Join(", ", randArray);
Console.WriteLine("[ " + str + " ]");