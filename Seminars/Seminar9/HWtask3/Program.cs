// Дана строка, содержащая только следующие символы:'(', ')', '{', '}', '[', ']'. Определите, является ли ваша строка допустимой.

bool CheckBrackets(string str)
{
    //любую открывающуюся скобку можно добавить в стэк без проверок
    //для каждой закрывающейся скобки надо проверить не пустой ли стэк, чтобы не получить ошибки при извлечении
    //и проверить лежит ли сверху стэка соответствующая ей открывающая (получается, что совпавшая пара удаляется)
    //в конце проверить стэк на пустоту, чтобы убедиться, что не осталось открытых скобок
    //оставила дефолтное значение в кейсе, чтобы можно было буквы пропускать, так вроде более общий случай получается

    Console.WriteLine(str);

    Stack<char> brackets = new Stack<char>();

    foreach (char sym in str)
    {
        switch (sym)
        {
            case '(' or '{' or '[':
                brackets.Push(sym);
                break;
            case ']':
                if (brackets.Count == 0) return false;
                if (brackets.Pop() != '[') return false;
                break;
            case ')':
                if (brackets.Count == 0) return false;
                if (brackets.Pop() != '(') return false;
                break;
            case '}':
                if (brackets.Count == 0) return false;
                if (brackets.Pop() != '{') return false;         
                break;
            default:
                break;
        }
    }
    if (brackets.Count > 0) return false;
    return true;
}
////////////////
string testStr = "(){}[]";
Console.WriteLine(CheckBrackets(testStr));
Console.WriteLine();

testStr = "({}[]";
Console.WriteLine(CheckBrackets(testStr));
Console.WriteLine();

testStr = "()[]{()}";
Console.WriteLine(CheckBrackets(testStr));
Console.WriteLine();

testStr = "a(aaa)[]{()}";
Console.WriteLine(CheckBrackets(testStr));
Console.WriteLine();

testStr = "(";
Console.WriteLine(CheckBrackets(testStr));
Console.WriteLine();