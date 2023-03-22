                                    // ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 2

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

                                    
                                    
                                    //ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 3 

                                    // //ЗАДАЧА 19
// /*
// bool five (int num)
// {
//     if (num > 99999 || num < 10000)
//     {Console.WriteLine("Введино не пятизначное число");
//     return false;
//     }
//     return true;
// }

// Console.WriteLine("Введите чило ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (five(num))
// {
//     if  (num / 10000 == num % 10 & num / 1000 % 10 == num /10 % 10)
//     {
//         Console.WriteLine("YES");
//     }
//     else
//     {
    
//         Console.WriteLine("NO");
//     }
    
// }
  
// */

// // ЗАДАЧА 21
/*
double Distanse20(double x1,double y1,double z1,double x2,double y2,double z2)
{
    double res = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return Math.Round(res , 2);
}

Console.Write("Введите кординату по Х для первой точки  ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату по Y для первой точки ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату по Z для первой точки ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату по Х для второй точки ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату по Y для второй точки ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату по Z для второй точки ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distans = Distanse20(x1,y1,z1,x2,y2,z2);
System.Console.WriteLine($"Расстояние между точками = {distans}");\
*/

// // ЗАДАЧА 21
/*

Console.Write("inpyt number ");
int number = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= number; i++)
{
    Console.Write($"{Math.Pow(i,3)} : ");
}
*/