//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Вариант 1

// int Naturnum (int num1 , int  num2)
// {
//     int count = 1;
//     int res = num1;
//     while (count < num2)
//     {
//     res *= num1;
//     count ++;
//     }
//     return res;
// }
// System.Console.WriteLine("Введите первое  число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе  число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"натуральная степень  числа {num1} в {num2} = {Naturnum(num1,num2)}");

//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Вариант 2


// System.Console.WriteLine("Введите первое  число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе  число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"натуральная степень  числа {num1} в {num2} = {Math.Pow(num1,num2)}");





//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// System.Console.WriteLine("Введите чило");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// while (num > 0)
//    {
//     sum += num % 10;
//     num = num / 10;
    
//    }
// System.Console.Write($"Сумма чисел = {sum}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



//  int[] Fillarrey (int size) 
// { 
//     int[] arr = new int [size];
//     Random rnd = new Random();  
//     for(int i = 0 ; i < arr.Length ; i++)
//     {
//         arr[i] = rnd.Next(1,9);
//     }
//     return arr;

// }
// ;
// int size = 8;                 
// int [] array = Fillarrey(size);  

// System.Console.WriteLine($"Массив из 8 случайных элементов = [{string.Join(",", array)}]");