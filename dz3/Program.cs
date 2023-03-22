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