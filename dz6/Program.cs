//Задача 41
/*
int [] ArrayI (int size)
{
    int [] arr  = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine($"Введите элемент  {i+1} ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

System.Console.Write("Введите длинну массива  больше 0 :  ");
int size = Convert.ToInt32(Console.ReadLine());
int [] arrey = ArrayI(size);



int sum = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if (arrey [i] > 0)
        {
            sum++;
        }
    }
System.Console.Write("Ваш массив  ");
System.Console.WriteLine($"[{string.Join(",",arrey)}]");
System.Console.WriteLine($"Количество элементов больше 0 > {sum}");
*/


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");

*/