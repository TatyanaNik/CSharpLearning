//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//Methods//////////////////////////
double GetDoubleFromConsole()
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

double[] GetLine()
{    
    double[] lineEq = new double[2];
    Console.Write("Введите коэффициент k: ");
    lineEq[0] = GetDoubleFromConsole();
    Console.Write("Введите коэффициент b: ");
    lineEq[1] = GetDoubleFromConsole();
    Console.WriteLine($"Введено уравнение вида y = {lineEq[0]} * x + {lineEq[1]}");
    return lineEq;
}

double[] CalcIntersectionPoint(double[] lineEq1, double[] lineEq2)
{
    double[] IntersectionPoint = new double[2];
    if (lineEq1[0] == lineEq2[0]){
        Console.WriteLine("Прямые параллельны или совпадают");
        Environment.Exit(0);
    }
    IntersectionPoint[0] = (lineEq2[1] - lineEq1[1]) / (lineEq1[0] - lineEq2[0]);
    IntersectionPoint[1] = lineEq1[0] * IntersectionPoint[0] + lineEq1[1];
    return IntersectionPoint;
}
///////////////////////////////////
Console.WriteLine("Ввод первого уравнения");
double[] line1 = GetLine();
Console.WriteLine("Ввод второго уравнения");
double[] line2 = GetLine();

string pointToStr = string.Join(", ", CalcIntersectionPoint(line1, line2));
Console.WriteLine($"точка пересечения (x,y) = (" + pointToStr + ")");

