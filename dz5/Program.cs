//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] Arrey(int size)
{
    int [] arr = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100,1000);
    }
    return arr;
}

System.Console.WriteLine("Введите длинну массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int [] arrey = Arrey(size);


int sum = 0;

for (int i = 0; i < arrey.Length; i++)
{
    if(arrey[i] % 2 == 0 )
    {
        sum +=1 ;
    }
    
}

System.Console.WriteLine("Ваш случайный массив: ");
System.Console.WriteLine($"[{string.Join(",",arrey)}]");
System.Console.WriteLine($"Количество четных чисел = {sum}");

*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

/*
int [] Arrey(int size)
{
    int [] arr = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1,100);
    }
    return arr;
}

System.Console.WriteLine("Введите длинну массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int [] arrey = Arrey(size);


int sum = 0;

for (int i = 1; i < arrey.Length; i = i+2)
{
    sum = arrey[i] + sum;
    
}

System.Console.WriteLine("Ваш случайный массив: ");
System.Console.WriteLine($"[{string.Join(",",arrey)}]"); 
System.Console.WriteLine($"сумму элементов, стоящих на нечётных позициях: = {sum}");
*/

// Задача 38: Задайте массив вещественных чисел(тип double). 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

/*
double [] Arrey(int size) 
{
    double [] arr = new double [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble()  ;
        
    }
    return arr;
}

System.Console.WriteLine("Введите длинну массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] randomArray =  Arrey(size);


double raz(double[] randomArray)
{
double min = randomArray[0];
double max = randomArray[0];
int i = 1;
while (i < randomArray.Length)
{
if (max<randomArray[i])
max = randomArray[i];
if (min>randomArray[i])
min = randomArray[i];
i = i + 1;
}
return max-min;
}


System.Console.WriteLine($"Ваш случайный массив: ");
System.Console.WriteLine($"[{string.Join(",",randomArray)}]");
System.Console.WriteLine($"Разница между наибольшим и наименьшим числом равна {raz(randomArray):F2}");
*/