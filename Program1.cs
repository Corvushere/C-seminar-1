//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Введи 2 числа");
            int x, y;
            Console.WriteLine("Введи свое первое число - ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи свое второе число - ");
            y = Convert.ToInt32(Console.ReadLine());
 
            if (x > y) Console.WriteLine( "Число " + x + " больше чем " + y);
            else if ( x == y ) Console.WriteLine( "Числа " + x + " и " + y + " равны");
            else Console.WriteLine( "Число " + y + " больше чем " + x);
            */


// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
int x1, x2, x3, max;
            Console.WriteLine("Введи свое первое число - ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи свое второе число - ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи свое третье число - ");
            x3 = Convert.ToInt32(Console.ReadLine());
    max=x1;
    if (x2 > max) max=x2; if  (x3 > max) max = x3;
    Console.WriteLine( "Максимальное число "+ max);
*/


// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
 int a;                             
            Console.Write("введите число: ");
            a= Convert.ToInt32(Console.ReadLine());
 
            if (a % 2==0)
            {
                Console.WriteLine("число четное");
           
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
 */


 //  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
     
 int n, i;                             
            Console.Write("введите число: ");
            n = Convert.ToInt32(Console.ReadLine());
            i = 1;
            while (i<=n)  
            {
            if (i % 2==0)
            {
            Console.Write( i + " " );
            }
            i=i+1;
            }