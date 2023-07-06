//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//Methods
bool search(int x, int[] array)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i] == x)
        {
            result = true;
            
            break;
        }
    }
    return result;
}


int[] sortArray(int[] array){
    int max = array[0];
    int tmp;

    for (int i = 0; i < array.Length; i++){
        for (int j = i; j < array.Length; j++){
            if (array[i] < array[j]){
                tmp = array[i];
                array[i] = array[j];
                array[j] = tmp;
            }
        }
    }

    var str = string.Join(",", array);
    Console.WriteLine(str);

    return array;
}

///////////////////////////////////////////////////

int[] array = { 5, 3, 0, 2 };
int num = 5;

Console.WriteLine(search(num, array));

sortArray(array);



