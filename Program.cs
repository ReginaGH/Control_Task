//Написать пр-му, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
//Первоначально массив можно ввести с клавиатуры, лио задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, т-о массивами.
// ["hello","2","world",":-)"] => ["2",":-)"]

string [] str = new string[]{"hello","2","world",":-)"};

void PrintArr(string[] str)
{
    for (int i = 0; i < str.Length; i++)
    {
        Console.WriteLine(str[i]);
    }
}
PrintArr(str);

int s =0;
void FindArraySize(string[] str)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (new string (str[i]).Length <= 3) s++;
    }
}
FindArraySize(str);

string [] str2 = new string[s];
void FillNewArray(string[] str)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (new string(str[i]).Length <= 3) 
        {
            str2[str2.Length-s] = str[i]; 
            s--;
        }
    }
}
FillNewArray(str);

PrintArr(str2);