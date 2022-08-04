/*Задание 1
Пользователь вводит с клавиатуры число в диапа-
    зоне от 1 до 100. Если число кратно 3 (делится на 3 без
остатка) нужно вывести слово Fizz. Если число кратно 5
нужно вывести слово Buzz. Если число кратно 3 и 5 нужно
    вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно
    вывести само число.
    Если пользователь ввел значение не в диапазоне от 1
до 100 требуется вывести сообщение об ошибке.);*/
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Security.Cryptography;
using System.Threading.Channels;

/*namespace FizzBuzz{
    class Numbers
    {
        public static void Main()
        {
            for (int num = 1; num <= 100; num++)  
            {  
                if (num % 3 == 0)  
                {  
                    Console.WriteLine("Fizz");  
                }  
                else if (num % 5 == 0)  
                {  
                    Console.WriteLine("Buzz");  
                }  
                else if (num % 3 == 0 && num % 5 == 0)  
                {  
                    Console.WriteLine("FizzBuzz");  
                }
                else  
                {  
                    Console.WriteLine(num);  
                }  
            }  

        }

    }
}*/

/*
Задание 2
Пользователь вводит с клавиатуры два числа. Первое
    число — это значение, второе число процент, который
необходимо посчитать. Например, мы ввели с клавиатуры
90 и 10. Требуется вывести на экран 10 процентов от 90.
    Результат: 9.
    */
/*
namespace percent
{
    class Num
    {
        public static void Main()
        {
            
            Console.WriteLine("Enter first number: ");
            int first;
            bool result = Int32.TryParse(Console.ReadLine(), out first);
            Console.WriteLine("Enter second number: ");
            int second;
            result = Int32.TryParse(Console.ReadLine(), out second);
            if (result)
            {
                Console.WriteLine(first * second / 100);
            }
            
        }
    }
}
*/
/*Задание 3
Пользователь вводит с клавиатуры четыре цифры.
    Необходимо создать число, содержащее эти цифры. На-
    пример, если с клавиатуры введено 1, 5, 7, 8 тогда нужно
сформировать число 1578*/

/*namespace Numbers
{
    class Number
    {
        public static void Main()
        {
            Console.WriteLine("Enter first number: ");
            int first;
            bool result = Int32.TryParse(Console.ReadLine(), out first);
        
            Console.WriteLine("Enter second number: ");
            int second;
            result = Int32.TryParse(Console.ReadLine(), out second);
            
            Console.WriteLine("Enter third number: ");
            int third;
            result = Int32.TryParse(Console.ReadLine(), out third);
            
            Console.WriteLine("Enter fourth number: ");
            int fourth;
            result = Int32.TryParse(Console.ReadLine(), out fourth);
            
            if (result)
            {
                Console.WriteLine(first*1000+second*100+third*10+fourth);
            }
            
        }
    }
}*/
/*Задание 5
Пользователь вводит с клавиатуры дату. Приложе-
    ние должно отобразить название сезона и дня недели.
    Например, если введено 22.12.2021, приложение должно
отобразить Winter Wednesday.*/
/*int year, month, day;
Console.WriteLine("Enter year: ");
year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter month: ");
month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter day: ");
day = Convert.ToInt32(Console.ReadLine());

if (year < 9999 && month < 12 && month > 0 && day > 0 && day < 31)
{
    DateTime dt = new DateTime(year, month, day);
    Console.WriteLine(dt.ToString("dd.MM.yyyy"));
    Console.WriteLine(dt.ToString("dddd @ hh:mm tt", System.Globalization.CultureInfo.InvariantCulture));
    
}*/

/*Задание 6
Пользователь вводит с клавиатуры показания тем-
    пературы. В зависимости от выбора пользователя про-
    грамма переводит температуру из Фаренгейта в Цельсий
или наоборот.*/
/*namespace degree
{
    class fahrenheit
    {
        public static void Main()
        {
            Console.WriteLine("Enter the temperature in fahrenheit: ");
            int fahrenheit;
            bool result = Int32.TryParse(Console.ReadLine(), out fahrenheit);
            Console.WriteLine("Enter the temperature in degree: ");
            int degree;
            result = Int32.TryParse(Console.ReadLine(), out degree);
            if (result)
            {
                Console.WriteLine((fahrenheit - fahrenheit )*5/9);
                Console.WriteLine((degree*9/5)+degree);
            }
        }
    }
}*/

/*Задание 7
Пользователь вводит с клавиатуры два числа. Нужно
    показать все четные числа в указанном диапазоне. Если
    границы диапазона указаны неправильно требуется про-
    извести нормализацию границ. Например, пользователь
    ввел 20 и 11, требуется нормализация, после которой
    начало диапазона станет равно 11, а конец 20*/

/*namespace Num
{
    class Number
    {
        public static void Main()
        {
            Console.WriteLine("Enter first number: ");
            int first;
            bool result = Int32.TryParse(Console.ReadLine(), out first);
            Console.WriteLine("Enter second number: ");
            int second;
            result = Int32.TryParse(Console.ReadLine(), out second);
            if (result)
            {
                if (second > first)
                {
                    var i = first;
                    var second1 = second + 1;

                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                    else if (first > second)
                    {
                        i = first + 1;
                        second1 = second;
                    }

                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}*/


