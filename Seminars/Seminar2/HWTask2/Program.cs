// S2HWT2
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
//author: NikitinaT

Console.Write("Please, enter integer number: ");
int Num = int.Parse(Console.ReadLine());

int index = 0;
int tmp = Num;

while(tmp != 0){
 tmp = tmp / 10;
 index++;
}

if ( index < 3 ){
    Console.WriteLine("третьей цифры нет");
}else{
    int digit3 = Math.Abs((Num / (int)Math.Pow(10,index - 3))%10);
    Console.WriteLine($"третья цифра: {digit3}");
}
