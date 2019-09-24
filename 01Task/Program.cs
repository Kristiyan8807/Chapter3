//Напишете израз, който да проверява дали дадено цяло число е четно
//или нечетно.
using System;

class Program
{
    static void Main(string[] arg)
    {
        int number = 33;
        Console.WriteLine((number % 2 == 0) ? "even" : "odd");
    }
}

