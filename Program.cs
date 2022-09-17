//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
System.Console.WriteLine("Задача 41:Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
System.Console.WriteLine("input int M");
int m = Convert.ToInt32(Console.ReadLine());
double [] array = new double[m];
for (int i=0; i < m; i++)
{
    System.Console.WriteLine($"Input M({i})");
    array [i] = Convert.ToInt32(Console.ReadLine());
}

int GetSumPozitiv(double [] array) // метод для подсчета положительных чисел в массиве
{
int countPozitiv = 0;
    for(int i=0; i < array.Length; i++) 
    {
        if (array[i] > 0)    countPozitiv = countPozitiv+1;
    }
    return countPozitiv;
}

System.Console.WriteLine($"количество положительных чисел = {GetSumPozitiv(array)}");

////////////////////////////////
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

System.Console.WriteLine();
System.Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых," + 
"заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
System.Console.WriteLine("input int b1");
double b1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("input int k1");
double k1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("input int b2");
double b2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("input int k2");
double k2 = Convert.ToInt32(Console.ReadLine());

// ReaderWriterLock GetCrossCoordinates(b1, k1, b2, k2)

if ( ( k1 == k2 ) && ( b1 == b2 ) )     System.Console.WriteLine("прямые совпадают");
    else if ( k1 == k2 ) System.Console.WriteLine("прямые параллельны");
        else
        {
            double x = ( b2 - b1 ) / ( k1-k2 );
            double y = ( k1 * ( b2- b1)) / ( k1- k2 ) + b1;
            System.Console.WriteLine( $"координаты пересечения: X={ x }   У={ y }" );
        }


