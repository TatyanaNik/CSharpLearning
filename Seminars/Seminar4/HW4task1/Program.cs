//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
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

///////////////////////////////////////////////////////

Console.Write("Введите число А: ");
int A = GetIntFromConsole();

Console.Write("Введите число B: ");
int B = GetIntFromConsole();

int result = A;

if (A == 0){
    result = 0;
}else if (B == 0){
    result = 1;
}else{
    for (int i = 1; i < B; i++)
    {
        result = result * result;
    }
}

Console.WriteLine("result = " + result);