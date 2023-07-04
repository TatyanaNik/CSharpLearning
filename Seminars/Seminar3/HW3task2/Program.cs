//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
//Methods/////////////////////////////////////////////////////
double GetDoubFromConsole()
{    
    string NumStr = Console.ReadLine();

    double x = 0;
    while (!(double.TryParse(NumStr, out x)))
    {
        Console.WriteLine("Некорректный ввод");
        Console.Write("Попробуйте еще раз: ");
        NumStr = Console.ReadLine();
    }
    return x;
}

double[] FillCoordArray(int N){
    double[] p = new double[N];

    Console.WriteLine($"Введите координаты точки в {N}-мерном пространстве (p0, p1, ..., p{N-1})");
    for (int i = 0; i < N; i++){
        Console.Write($"insert p{i}: ");
        p[i] = GetDoubFromConsole();
    }

    return p;
}

double CalcDistance(int N, double[] p, double[] q){
    double dist = 0;
    for (int i = 0; i < N; i++){
        dist = dist + Math.Pow(p[i]-q[i], 2);
    }
    return Math.Sqrt(dist);    
}
////////////////////////////////////////////////////////////

Console.Write("Введите размерность пространства N: ");
int n = Convert.ToInt32(GetDoubFromConsole());

Console.WriteLine("Ввод первой точки");
double[] p = FillCoordArray(n);

Console.WriteLine("Ввод второй точки");
double[] q = FillCoordArray(n);

var pStr = string.Join(",", p);
var qStr = string.Join(",", q);
Console.WriteLine("Евклидово расстояние между точками х("+pStr+ ") и y("+ qStr+ ") = " + CalcDistance(n, p, q));
//Console.WriteLine(str);
//Console.Write("finish");