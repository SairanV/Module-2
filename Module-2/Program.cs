using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //~~1
    /*class Program
    {

        static void Main(string[] args)
        {


            int spaceCount = 0;

            Console.WriteLine("Введите текст. Для завершения введите точку.");

            while (true)
            {
                char inputChar = Console.ReadKey().KeyChar;

                if (inputChar == '.')
                    break;

                if (inputChar == ' ')
                    spaceCount++;
            }

            Console.WriteLine($"\nКоличество пробелов: {spaceCount}");
        }
    }
    */


    //~~2
    /* class Program
     {

         static void Main(string[] args)
         {
             Console.Write("Enter number трамвай ticket: ");
             string ticketNumberInput = Console.ReadLine();

             if (ticketNumberInput.Length != 6 || !int.TryParse(ticketNumberInput, out int ticketNumber))
             {
                 Console.WriteLine("Not very good.");
                 return;
             }

             int digit1 = ticketNumber / 100000;
             int digit2 = (ticketNumber / 10000) % 10;
             int digit3 = (ticketNumber / 1000) % 10;
             int digit4 = (ticketNumber / 100) % 10;
             int digit5 = (ticketNumber / 10) % 10;
             int digit6 = ticketNumber % 10;

             if (digit1 + digit2 + digit3 == digit4 + digit5 + digit6)
             {
                 Console.WriteLine("You are lucky dude");
             }
             else
             {
                 Console.WriteLine("You are not lucky dude");
             }
         }

     }
    */


    //~~4
    /* class Program
     {

         static void Main(string[] args)
         {
             Console.WriteLine("!!!!!   A < B   !!!!!");
             Console.Write("A: ");
             int A = Convert.ToInt32(Console.ReadLine());
             Console.Write("B: ");
             int B = Convert.ToInt32(Console.ReadLine());

             if (A < B)
             {

                 for (int i = A; i <= B; i++)
                 {
                     for (int j = 0; j < i; j++)
                     {
                         Console.Write(i + " ");
                     }
                     Console.WriteLine();
                     Console.WriteLine("Nice bro, veri perfect");
                 }
             }
             else
             {
                 Console.WriteLine("Can you even read?");
             }
         }

     }
    */


    //~~5
    /* class Program
     {
         static void Main()
         {
             Console.WriteLine("Введите целое число N (> 0):");

             string input = Console.ReadLine();

             if (int.TryParse(input, out int n) && n > 0)
             {
                 int reversedNumber = ReverseNumber(n);
                 Console.WriteLine($"Обратное число: {reversedNumber}");
             }
             else
             {
                 Console.WriteLine("Ошибка: Введите корректное положительное целое число.");
             }
         }

         static int ReverseNumber(int number)
         {
             int reversedNumber = 0;
             while (number > 0)
             {
                 int remainder = number % 10;
                 reversedNumber = reversedNumber * 10 + remainder;
                 number /= 10;
             }
             return reversedNumber;
         }
     }
    */


    //~~9
    /* class Program
     {
         static void Main()
         {
             int days = 234;
             int weeks = days / 7;

             Console.WriteLine($"За {days} дней прошло {weeks} полных недель.");
         }
     }
    */


    //~~10
    /* class Program
     {
         static void Main()
         {
             Console.WriteLine("Введите двузначное число:");
             int number = int.Parse(Console.ReadLine());


             if (number >= 10 && number <= 99)
             {
                 // a. Найти число десятков
                 int tens = number / 10;

                 // b. Найти число единиц
                 int ones = number % 10;

                 // c. Найти сумму цифр
                 int sum = tens + ones;

                 // d. Найти произведение цифр
                 int product = tens * ones;

                 Console.WriteLine($"Число десятков: {tens}");
                 Console.WriteLine($"Число единиц: {ones}");
                 Console.WriteLine($"Сумма цифр: {sum}");
                 Console.WriteLine($"Произведение цифр: {product}");
             }
             else
             {
                 Console.WriteLine("Ошибка: Введите двузначное число.");
             }
         }
     }
    */


    //~~12
    /* class Program
     {
         static void Main()
         {
             Console.WriteLine("Введите радиус круга:");
             double radius = double.Parse(Console.ReadLine());

             Console.WriteLine("Введите длину стороны квадрата:");
             double side = double.Parse(Console.ReadLine());


             double circleArea = Math.PI * Math.Pow(radius, 2);
             double squareArea = Math.Pow(side, 2);

             if (circleArea > squareArea)
             {
                 Console.WriteLine("Площадь круга больше.");
             }
             else if (circleArea < squareArea)
             {
                 Console.WriteLine("Площадь квадрата больше.");
             }
             else
             {
                 Console.WriteLine("Площади равны.");
             }
         }
     }*/


    //~~15
    /* class Program
     {
         static void Main()
         {
             // a. Вывести все целые числа от 20 до 35:
             Console.WriteLine("a. Все целые числа от 20 до 35:");
             for (int i = 20; i <= 35; i++)
             {
                 Console.WriteLine(i);
             }

             Console.WriteLine(); 

             // b. Вывести квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры):
             Console.WriteLine("b. Введите значение b (b > 10):");
             int b = int.Parse(Console.ReadLine());
             Console.WriteLine("Квадраты чисел от 10 до " + b + ":");
             for (int i = 10; i <= b; i++)
             {
                 int square = i * i;
                 Console.WriteLine($"Квадрат числа {i} равен {square}");
             }

             Console.WriteLine(); 

             // c. Вывести третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50):
             Console.WriteLine("c. Введите значение a (a < 50):");
             int a = int.Parse(Console.ReadLine());
             Console.WriteLine("Третьи степени чисел от " + a + " до 50:");
             for (int i = a; i <= 50; i++)
             {
                 int cube = i * i * i;
                 Console.WriteLine($"Третья степень числа {i} равна {cube}");
             }

             Console.WriteLine(); 

             // d. Вывести все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a):
             Console.WriteLine("d. Введите значение a:");
             a = int.Parse(Console.ReadLine());

             Console.WriteLine("Введите значение b (b > a):");
             b = int.Parse(Console.ReadLine());

             Console.WriteLine($"Все целые числа от {a} до {b}:");
             for (int i = a; i <= b; i++)
             {
                 Console.WriteLine(i);
             }
         }
     }
    */


    //~~16
    /*class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значение x:");
            double x = double.Parse(Console.ReadLine());

            double y = 7 * Math.Pow(x, 2) - 3 * x + 6;

            Console.WriteLine($"Значение функции y = 7x^2 - 3x + 6 при x = {x} равно {y}");
        }
    }
    */


    //~~17
    /*class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значение a:");
            double a = double.Parse(Console.ReadLine());

            double x = 12 * Math.Pow(a, 2) + 7 * a - 16;

            Console.WriteLine($"Значение функции x = 12a^2 + 7a - 16 при a = {a} равно {x}");
        }
    }
    */


    //~~18
    /* class Program
     {
         static void Main()
         {
             Console.WriteLine("Введите длину стороны квадрата:");
             double side = double.Parse(Console.ReadLine());

             double perimeter = 4 * side;

             Console.WriteLine($"Периметр квадрата со стороной {side} равен {perimeter}");
         }
     }
    */


    //~~19
    /* class Program
     {
         static void Main()
         {
             Console.WriteLine("Введите радиус окружности:");
             double radius = double.Parse(Console.ReadLine());

             double diameter = 2 * radius;

             Console.WriteLine($"Диаметр окружности с радиусом {radius} равен {diameter}");
         }
     }
    */


    //~~20
    /* class Program
     {
         static void Main()
         {
             double radiusOfEarth = 6350.0; // Радиус Земли в километрах

             Console.WriteLine("Введите высоту над Землей (в километрах):");
             double height = double.Parse(Console.ReadLine());

             double distanceToHorizon = Math.Sqrt(Math.Pow(radiusOfEarth + height, 2) - Math.Pow(radiusOfEarth, 2));

             Console.WriteLine($"Расстояние до линии горизонта: {distanceToHorizon} километров");
         }
     }
    */


    //~~27
    /* class Program
     {
         static void Main()
         {
             bool X = false;
             bool Y = true;
             bool Z = false;

             bool resultA = X || Z;
             bool resultB = X && Y;
             bool resultC = X && Z;

             Console.WriteLine($"a. X или Z: {resultA}");
             Console.WriteLine($"b. X и Y: {resultB}");
             Console.WriteLine($"c. X и Z: {resultC}");
         }
     }*/


    //~~28
    /* class Program
     {
         static void Main()
         {
             bool A = true;
             bool B = false;
             bool C = false;

             bool resultA = !A && B;
             bool resultB = A || !B;
             bool resultC = (A && B) || C;

             Console.WriteLine($"a. не A и B: {resultA}");
             Console.WriteLine($"b. A или не B: {resultB}");
             Console.WriteLine($"c. (A и B) или C: {resultC}");
         }
     }
    */


    //~~29
    /*class Program
    {
        static void Main()
        {
            bool X = false;
            bool Y = true;
            bool Z = false;

            bool resultA = X && !(Z || Y) || !Z;
            bool resultB = !X || X && (Y || Z);
            bool resultC = (X || Y && !Z) && Z;

            Console.WriteLine($"a. X и не (Z или Y) или не Z: {resultA}");
            Console.WriteLine($"b. не X или X и (Y или Z): {resultB}");
            Console.WriteLine($"c. (X или Y и не Z) и Z: {resultC}");
        }
    }
    */


    //~~30
    /* class Program
     {
         static void Main()
         {
             double number1 = 10.5;
             double number2 = 8.3;

             if (number1 > number2)
             {
                 Console.WriteLine("a. Первое число больше второго.");
             }
             else if (number1 < number2)
             {
                 Console.WriteLine("a. Второе число больше первого.");
             }
             else
             {
                 Console.WriteLine("a. Числа равны.");
             }
         }
     }
    */


    //~~31
    /* class Program
     {
         static void Main()
         {
             double distanceInKilometers = 10.0;
             double distanceInFeet = 50.0;

             double distanceInMeters = distanceInFeet * 0.305;

             if (distanceInKilometers < distanceInMeters)
             {
                 Console.WriteLine("Расстояние в километрах меньше.");
             }
             else if (distanceInKilometers > distanceInMeters)
             {
                 Console.WriteLine("Расстояние в метрах меньше.");
             }
             else
             {
                 Console.WriteLine("Расстояния равны.");
             }
         }
     }
    */


    //~~32
    /*class Program
    {
        static void Main()
        {
            int number = 37;

            bool isEven = number % 2 == 0;

            bool endsWith7 = number % 10 == 7;

            Console.WriteLine($"a. Число является четным: {isEven}");
            Console.WriteLine($"b. Число оканчивается на 7: {endsWith7}");
        }
    }
    */


    //~~40
    /* class Program
     {
         static void Main()
         {
             // a. Все целые числа от 20 до 35:
             Console.WriteLine("a. Все целые числа от 20 до 35:");
             for (int i = 20; i <= 35; i++)
             {
                 Console.WriteLine(i);
             }

             // b. Квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b больше или равно 10):
             Console.WriteLine("b. Введите значение b (b >= 10):");
             int b = int.Parse(Console.ReadLine());

             Console.WriteLine($"Квадраты чисел от 10 до {b}:");
             for (int i = 10; i <= b; i++)
             {
                 int square = i * i;
                 Console.WriteLine(square);
             }

             // c. Третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a меньше или равно 50):
             Console.WriteLine("c. Введите значение a (a <= 50):");
             int a = int.Parse(Console.ReadLine());

             Console.WriteLine($"Третьи степени чисел от {a} до 50:");
             for (int i = a; i <= 50; i++)
             {
                 int cube = i * i * i;
                 Console.WriteLine(cube);
             }

             // d. Все целые числа от a до b (значения a и b вводятся с клавиатуры; b больше или равно a):
             Console.WriteLine("d. Введите значение a:");
             a = int.Parse(Console.ReadLine());

             Console.WriteLine("Введите значение b (b >= a):");
             b = int.Parse(Console.ReadLine());

             Console.WriteLine($"Все целые числа от {a} до {b}:");
             for (int i = a; i <= b; i++)
             {
                 Console.WriteLine(i);
             }
         }
     }
    */
}