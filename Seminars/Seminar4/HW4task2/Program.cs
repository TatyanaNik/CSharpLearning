//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//Methods/////////////////////////////////////////////////////
bool CheckInt(string NumStr)
{

    try
    {
        int x = int.Parse(NumStr);
        if (x >= 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    catch
    {
        Console.WriteLine("Некорректный ввод");
        return false;
    }
}

/////////////////////////////////////////////////////

Console.Write("Введите целое положительное число: ");
string userStr = Console.ReadLine();

while (!CheckInt(userStr))
{
    Console.Write("Попробуйте еще раз: ");
    userStr = Console.ReadLine();
}

int digitSum = 0;

for (int i = 0; i < userStr.Length; i++)
{
    digitSum = digitSum + (int)Char.GetNumericValue(userStr[i]);
}

Console.WriteLine("Cумма цифр числа " + userStr + " = " + digitSum);
