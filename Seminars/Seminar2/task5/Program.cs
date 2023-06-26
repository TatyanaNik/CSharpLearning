Console.Write("Please, enter integer number: ");
int Num = int.Parse(Console.ReadLine());

int index = 0;

while(Num/10 != 0){
 Num = Num / 10;
 index++;
}

Console.WriteLine(index+1);
