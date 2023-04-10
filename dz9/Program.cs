//Задача 64
/*
void PrintNumberToN(int N)
{
    if (N > 0)
    {
        System.Console.Write($"{N} ");
    }
    if(N == 0)
    {
        return;
    }
    
PrintNumberToN(N - 1);

}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNumberToN(number);

*/

//Задача 66

/*

int SumRec(int number1 , int number2)
{
if (number1 > number2 )
{
return 0;
}
return number1  + SumRec(number1 + 1  , number2 );
}



System.Console.Write("Введите минимальное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите максимальное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumRec(number1,number2));


*/

//Задача 68

/*

int Ack (int M, int N)
{
    if (M == 0) 
    {
        return N + 1;
    }
    if (M != 0 && N == 0) 
    {
        return Ack(M - 1, 1);
    }
    if (M > 0 && N > 0) 
    {
        return Ack(M - 1, Ack(M, N - 1));
    }
    return Ack(M, N);
}


System.Console.Write("Введите  число M : ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите  число N : ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Функция Аккермана для чисел A({number1},{number2}) = {Ack(number1, number2)}");

*/