//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//Methods/////////////////////////////////////////////////////
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
////////////////////////////////////////////////////////////////
Console.WriteLine("Сколько чисел будем анализировать?");
int N = GetIntFromConsole();
int nPositive = 0;

for (int i = 0; i < N; i++){
    Console.Write($"Вводим число {i+1}: ");
    if (GetIntFromConsole() > 0){
        nPositive ++;
    }
}

Console.WriteLine("Количество положительных чисел: " + nPositive);
