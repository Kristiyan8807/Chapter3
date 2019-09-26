//Напишете израз, който да проверява дали дадено цяло число е четно
//или нечетно.
using System;

class Program
{
    static void Main(string[] arg)
    {
        int number = 28;
        Console.WriteLine((number % 2 == 0) ? "even" : "odd");

        /*
        if (number % 2 == 0) 
        {

            Console.WriteLine("even");
        }
        else
        {

            Console.WriteLine("odd");
        }
        */

        int number1 = 57;
        int number2 = 8;
        Console.WriteLine(number1 % number2);
    }
}

