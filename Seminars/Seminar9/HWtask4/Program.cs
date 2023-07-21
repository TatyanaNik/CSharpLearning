// Даны два положительных целых числа, представленных в виде строк. 
//Необходимо получить сумму чисел, которые представлены этими строками. 
//Причем полученная сумма должна быть преобразована в строку.
//Для решения этой задачи запрещено преобразовывать входные строки сразу напрямую в целое число при помощи встроенной функции. 
//Необходимо сделать это самостоятельно.
int ConvertStringToInt(string str){
    int result = 0;
    for(int i = 0; i < str.Length; i++){
        int tmp = str[i] - '0';
        result += tmp * Convert.ToInt32(Math.Pow(10,str.Length-1-i));
    }
    Console.WriteLine(result);
    return result;
}

string SummAndConvert(int A, int B){
    return Convert.ToString(A + B);
}
/////////////////////////////
string a = "123";
string b = "7";
Console.WriteLine("= " + SummAndConvert(ConvertStringToInt(a),ConvertStringToInt(b)));