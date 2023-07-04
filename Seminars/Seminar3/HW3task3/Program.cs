//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
//от 1 до N.
//Methods/////////////////////////////////////////////////////
double GetIntFromConsole()
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

void PrintCubeTab(int N){
    if (N < 1) {
        Console.WriteLine("Не существует чисел, удовлетворяющих условию");
    }else{
        Console.Write($"{N} --> ");
        for (int i = 1; i <= N; i++){            
            Console.Write($"{Math.Pow(i,3)}; ");
        }
        Console.WriteLine(" ");
        
    }  
}

//////////////////////////////////////////////////////////

Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());
PrintCubeTab(num);
