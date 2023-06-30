//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
//Methods///////////////////////////////////////////////////////////////
/*string GetData (){
    Console.Write("insert value:");
    string NumStr = Console.ReadLine();
    if (int.TryParse(NumStr, out var x))
    {
        return NumStr;
    }
    else
    {
        Console.WriteLine("Некорректный ввод");
        return "null";
    }
    if (Num < 100000 && Num > 9999)
    {
        return Num.ToString();
    }
    else
    {
        Console.WriteLine("invalid data");
        return "NULL";
    }
}*/
void CheckPal(string str){
    bool checkFlag = true;
    for (int i =0; i < str.Length/2; i++){
        if (str[i] != str[str.Length-1-i]){
           checkFlag = false;
           break;
        }
    }

    if (checkFlag == false){
        Console.WriteLine(str + "-> не палиндром");
    }else{
        Console.WriteLine(str + "-> палиндром");
    }
}
////////////////////////////////////////////////////////////////////////

    Console.Write("insert value: ");
    string NumStr = Console.ReadLine();
    if (int.TryParse(NumStr, out var x))
    {
        CheckPal(NumStr);
    }
    else
    {
        Console.WriteLine("Некорректный ввод");        
    }
