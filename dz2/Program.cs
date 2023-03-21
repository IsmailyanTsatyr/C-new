
//Задача 1
/*
int Oper (int num)
{
    int result = num / 10 % 10;
    return result;
}

Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine()); 
    if (number < 100 || number >1000)
{
        Console.WriteLine("вы ввели не трехзначное число");
        return;
}
 Console.WriteLine(Oper(number));
*/


//Задача 2 
/*
int Thard (int num)
{
    while (num>999)
    {
        num = num / 10;

    }
    return num % 10;
}

bool Chec (int num)
{
    if (num < 100)
    {
        Console.WriteLine("третей цыфры нет");
        return false;
    }
    return true;
}

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine()); 
if (Chec(number))
{
    Console.WriteLine(Thard(number));
}
*/

//Задача 3 
/*
bool Checked (int num)
{
    if (num > 7 || num < 1)
    {
        Console.WriteLine("это не день недели");
        return false;
    }
    return true;
}

bool Prog (int num)
{
    if (num>5)
    {
        return true;
    }
    return false;
}

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine()); 
if (Checked(number))
{
    if (Prog(number))
    {
    Console.WriteLine("Выходной");
    }
    else 
    {
    Console.WriteLine("Будний");  
    }
}
*/


 