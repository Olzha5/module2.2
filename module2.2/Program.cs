using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер трамвайного билета (6-значное число):");

            string ticketNumber = Console.ReadLine();

            if (ticketNumber.Length != 6 || !Int32.TryParse(ticketNumber, out _))
            {
                Console.WriteLine("Некорректный ввод. Номер билета должен быть 6-значным числом.");
                return;
            }

            int firstHalf = Convert.ToInt32(ticketNumber.Substring(0, 3));
            int secondHalf = Convert.ToInt32(ticketNumber.Substring(3, 3));

            int sumFirstHalf = SumOfDigits(firstHalf);
            int sumSecondHalf = SumOfDigits(secondHalf);

            if (sumFirstHalf == sumSecondHalf)
            {
                Console.WriteLine("Билет счастливый!");
            }
            else
            {
                Console.WriteLine("Билет не счастливый.");
            }
        }

        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}


//Программа, которая считывает строку с клавиатуры и конвертирует все 
//    символы нижнего регистра в символы верхнего регистра и наоборот:
////using System;

//namespace ConvertCase
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите строку:");
//            string input = Console.ReadLine();

//            char[] convertedChars = new char[input.Length];
//            for (int i = 0; i < input.Length; i++)
//            {
//                char ch = input[i];
//                if (char.IsLower(ch))
//                {
//                    convertedChars[i] = char.ToUpper(ch);
//                }
//                else if (char.IsUpper(ch))
//                {
//                    convertedChars[i] = char.ToLower(ch);
//                }
//                else
//                {
//                    convertedChars[i] = ch;
//                }
//            }

//            string convertedString = new string(convertedChars);
//            Console.WriteLine($"Конвертированная строка: {convertedString}");
//        }
//    }
//}

//4/Программа, которая выводит числа от A до B включительно:

//using System;

//namespace PrintNumbers
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Введите число A: ");
//            int A = int.Parse(Console.ReadLine());

//            Console.Write("Введите число B: ");
//            int B = int.Parse(Console.ReadLine());

//            for (int i = A; i <= B; i++)
//            {
//                for (int j = 0; j < i; j++)
//                {
//                    Console.Write(i + " ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}





//namespace ReverseNumber
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Введите число N: ");
//            int N = int.Parse(Console.ReadLine());

//            int reversedNumber = 0;
//            while (N > 0)
//            {
//                reversedNumber = reversedNumber * 10 + N % 10;
//                N /= 10;
//            }

//            Console.WriteLine($"Число, прочитанное справа налево: {reversedNumber}");
//        }
//    }
//}




//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("5  10  21");
//    }
//}
//Console.WriteLine("5\n10\n21");
//int distanceInCentimeters = 2500;
//int meters = distanceInCentimeters / 100;
//Console.WriteLine($"{meters} метров");
//int days = 234;
//int weeks = days / 7;
//Console.WriteLine($"{weeks} полных недель");
//int number = 47;
//int tens = number / 10;
//int units = number % 10;

//Console.WriteLine($"a. Число десятков: {tens}");
//Console.WriteLine($"b. Число единиц: {units}");
//Console.WriteLine($"c. Сумма цифр: {tens + units}");
//Console.WriteLine($"d. Произведение цифр: {tens * units}");
//bool A = true;
//bool B = false;
//bool C = false;

//Console.WriteLine($"a. А или В: {A || B}");
//Console.WriteLine($"b. А и В: {A && B}");
//Console.WriteLine($"c. В или С: {B || C}");
//double radius = 5.0;
//double sideOfSquare = 8.0;

//double areaOfCircle = Math.PI * radius * radius;
//double areaOfSquare = sideOfSquare * sideOfSquare;

//if (areaOfCircle > areaOfSquare)
//{
//    Console.WriteLine("Площадь круга больше.");
//}
//else if (areaOfCircle < areaOfSquare)
//{
//    Console.WriteLine("Площадь квадрата больше.");
//}
//else
//{
//    Console.WriteLine("Площади равны.");
//}


//15
//using System;

//class Program
//{
//    static void Main()
//    {
//        // 15. Напечатать "столбиком":
//        Console.WriteLine("15.");
//        // a. все целые числа от 20 до 35;
//        for (int i = 20; i <= 35; i++) Console.WriteLine(i);

//        // b. квадраты всех целых чисел от 10 до b
//        Console.Write("Введите число b (b > 10): ");
//        int b = Convert.ToInt32(Console.ReadLine());
//        for (int i = 10; i <= b; i++) Console.WriteLine(i * i);

//        // c. третьи степени всех целых чисел от a до 50
//        Console.Write("Введите число a (a < 50): ");
//        int a = Convert.ToInt32(Console.ReadLine());
//        for (int i = a; i <= 50; i++) Console.WriteLine(Math.Pow(i, 3));

//        // d. все целые числа от a до b
//        Console.Write("Введите число a: ");
//        a = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Введите число b (b > a): ");
//        b = Convert.ToInt32(Console.ReadLine());
//        for (int i = a; i <= b; i++) Console.WriteLine(i);

//        // 16. y= 7x^2-3x+6
//        Console.WriteLine("16.");
//        Console.Write("Введите значение x: ");
//        double x = Convert.ToDouble(Console.ReadLine());
//        double y = 7 * Math.Pow(x, 2) - 3 * x + 6;
//        Console.WriteLine($"y = {y}");

//        // 17. x= 12a^2+7a-16
//        Console.WriteLine("17.");
//        Console.Write("Введите значение a: ");
//        double aVal = Convert.ToDouble(Console.ReadLine());
//        double xVal = 12 * Math.Pow(aVal, 2) + 7 * aVal - 16;
//        Console.WriteLine($"x = {xVal}");

//       using System;

//namespace HomeworkTasks
//{
//    class Program
//    {
//        static void Main()
//        {
//            // 18. Дана сторона квадрата. Найти его периметр.
//            Console.WriteLine("18.");
//            Console.Write("Введите сторону квадрата: ");
//            double side = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine($"Периметр квадрата: {4 * side}");

//            // 19. Дан радиус окружности. Найти ее диаметр.
//            Console.WriteLine("19.");
//            Console.Write("Введите радиус окружности: ");
//            double radius = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine($"Диаметр окружности: {2 * radius}");

//            // 20. Расстояние до линии горизонта.
//            Console.WriteLine("20.");
//            const double EarthRadius = 6350; // in km
//            Console.Write("Введите высоту над Землёй (в км): ");
//            double height = Convert.ToDouble(Console.ReadLine());
//            double distanceToHorizon = Math.Sqrt((EarthRadius + height) * (EarthRadius + height) - EarthRadius * EarthRadius);
//            Console.WriteLine($"Расстояние до линии горизонта: {distanceToHorizon} км");

//            // 21. Значение функции z.
//            Console.WriteLine("21.");
//            Console.Write("Введите значение x: ");
//            double xValue = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Введите значение y: ");
//            double yValue = Convert.ToDouble(Console.ReadLine());
//            double zValue = Math.Pow(xValue, 3) - 2.5 * xValue * yValue + 1.78 * xValue * xValue - 2.5 * yValue + 1;
//            Console.WriteLine($"Значение функции z: {zValue}");

//            // 22. Среднее арифметическое и среднее геометрическое.
//            Console.WriteLine("22.");
//            Console.Write("Введите первое число: ");
//            double num1 = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Введите второе число: ");
//            double num2 = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine($"Среднее арифметическое: {(num1 + num2) / 2}");
//            Console.WriteLine($"Среднее геометрическое: {Math.Sqrt(num1 * num2)}");

//           .

//            // Например, 23. Плотность материала тела.
//            Console.WriteLine("23.");
//            Console.Write("Введите объем тела (в м^3): ");
//            double volume = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Введите массу тела (в кг): ");
//            double mass = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine($"Плотность материала: {mass / volume} кг/м^3");

           
//        }
//    }
//}


//        
//    }
//}



