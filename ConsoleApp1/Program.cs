using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1.  Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.*/
            Console.WriteLine("Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.");
            int number1, number2, number3;
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число 1: " + number1 + ", Число 2: " + number2 + ", Число 3: " + number3);
            Console.ReadLine();

            /* 2.	Вывести на экран числа 5, 10 и 21 одно под другим*/
            Console.WriteLine("Вывести на экран числа 5, 10 и 21 одно под другим.");
            int num1, num2, num3;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число 1: " + num1);
            Console.WriteLine("Число 2: " + num2);
            Console.WriteLine("Число 3: " + num3);
            Console.ReadLine();

            /*3.	Дано расстояние в сантиметрах. Найти число полных метров в нем*/
            Console.WriteLine("Дано расстояние в сантиметрах. Найти число полных метров в нем");
            int dist_sm; //дистанция в см
            Console.WriteLine("Введите расстояние в сантиметрах = ");
            dist_sm = Convert.ToInt32(Console.ReadLine());
            double dist_m = dist_sm / 100.0; //перевод на метр
            Console.WriteLine("Расстояние в метрах =" + dist_m + "метр");
            Console.WriteLine("Нажмите Enter для перехода следующе задания");
            Console.ReadLine();

            /*4.	С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?*/
            Console.WriteLine("С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?");
            int day = 234;
            int week = day / 7;
            Console.WriteLine("Полных недель с момента 234 дня - " + week);
            Console.WriteLine("Нажмите Enter для перехода следующе задания");
            Console.ReadLine();

            /*5.	Дано двузначное число. Найти:
                    a.	число десятков в нем;
                    b.	число единиц в нем;
                    c.	сумму его цифр;
                    d.	произведение его цифр
            */
            Console.WriteLine("Дано двузначное число. Найти:");
            Console.WriteLine("a.	число десятков в нем");
            Console.WriteLine("b.	число единиц в нем");
            Console.WriteLine("c.	сумму его цифр");
            Console.WriteLine("d.	произведение его цифр");

            int TwoDigit; //двузначное число
            Console.WriteLine("Введите двузначное число: ");
            TwoDigit = Convert.ToInt32(Console.ReadLine());
            if (TwoDigit > 9 & TwoDigit < 100)
            {
                int result = TwoDigit / 10; //число десятков в нем
                Console.WriteLine("Число десятков в нем = " + result);
                int result2 = TwoDigit % 10; //число десятков в нем
                Console.WriteLine("Число единиц в нем = " + result2);
                int result3 = TwoDigit % 10 + TwoDigit / 10; //сумму его цифр
                Console.WriteLine("Сумму его цифр = " + result3);
                int result4 = TwoDigit % 10 * TwoDigit / 10; //произведение его цифр
                Console.WriteLine("произведение его цифр = " + result4);
            }
            else
            {
                Console.WriteLine("Число не двузначное");
            }
            Console.WriteLine("Нажмите Enter для перехода следующе задания");
            Console.ReadLine();

            /*6.	Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
                    a.	А или В; 
                    b.	А и В; 
                    c.	В или С.

           */
            Console.WriteLine("Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:");
            Console.WriteLine("a.	А или В");
            Console.WriteLine("b.	А и В");
            Console.WriteLine("c.	В или С");

            bool A = true;
            bool B = false;
            bool C = false;
            if (A || B)
            {
                Console.WriteLine("true");
            }
            if (A & B)
            {
                Console.WriteLine("false");
            }
            if (B || C)
            {
                Console.WriteLine("false");
            }
            Console.WriteLine("Нажмите Enter для перехода следующе задания");
            Console.ReadLine();

            /*7.	Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?*/
            Console.WriteLine("Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?");
            int radius;     //радиус круга
            int dlina;      //длина сторон квадрата
            Console.WriteLine("Введите длину радиуса = ");
            radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину сторон квадрата = ");
            dlina = Convert.ToInt32(Console.ReadLine());
            double Pi = 3.14;
            double area_circle = Pi * radius * radius;                      //площадь круга
            int area_squre = dlina * dlina;                            //площадь квадрат
            Console.WriteLine("Площадь круга = " + area_circle);
            Console.WriteLine("Площадь квадрата = " + area_squre);
            if (area_circle > area_squre)
            {
                Console.WriteLine("Площадь круга больше площади квадрата");
            }
            else
            {
                Console.WriteLine("Площадь площадь больше площади круга");

            }
            Console.WriteLine("Нажмите Enter для перехода следующе задания");
            Console.ReadLine();

            /* 8. Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность ? */
            Console.WriteLine("Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность ?");
            int volume1, volume2;     //объем
            int massa1, massa2;      //масса
            Console.WriteLine("Введите объем 1 тела = ");
            volume1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите объем 2 тела = ");
            volume2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите массу 1 тела = ");
            massa1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите массу 2 тела = ");
            massa2 = Convert.ToInt32(Console.ReadLine());
            double density1 = massa1 / volume1;               //плотность 1 тела
            double density2 = massa2 / volume2;               //плотность 2 тела
            Console.WriteLine("Плотность 1 тела = " + density1);
            Console.WriteLine("Плотность 2 тела = " + density2);
            if (density1 > density2)
            {
                Console.WriteLine("Плотность 1 тела больше 2 тела");
            }
            else
            {
                Console.WriteLine("Плотность 2 тела больше 1 тела");
            }
            Console.WriteLine("Нажмите Enter для перехода следующе задания");
            Console.ReadLine();

            /* 9. Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них. По какому участку протекает меньший ток?*/
            Console.WriteLine("Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них. По какому участку протекает меньший ток?");
            int U1, U2;     //напряжение
            int R1, R2;      //сопротивления
            Console.WriteLine("Введите напряжение U 1 цепи = ");
            U1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите напряжение U 2 цепи = ");
            U2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сопротивления R 1 цепи = ");
            R1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сопротивления R 2 цепи = ");
            R2 = Convert.ToInt32(Console.ReadLine());
            double current1 = U1 / R1;               //ток 1 цепи
            double current2 = U2 / R2;               //ток 2 цепи
            Console.WriteLine("ток 1 цепи = " + current1);
            Console.WriteLine("ток 2 цепи = " + current2);
            if (current1 > current2)
            {
                Console.WriteLine("на 2 цепи протекает меньший ток ");
            }
            else
            {
                Console.WriteLine("на 1 цепи протекает меньший ток");
            }
            Console.WriteLine("Нажмите Enter для перехода следующе задания");
            Console.ReadLine();

            Console.WriteLine("Напечатать \"столбиком\": a.все целые числа от 20 до 35");
            for (int i = 20; i <= 35; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
                
            }
            Console.ReadLine();
           

        }
    }
}
