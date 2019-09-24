//Напишете булев израз, който да проверява дали дадено цяло число се
//дели и на 5, и на 7 без остатък.
using System;

class Program
{
    static void Main(string[] arg)
    {
        int number = 25;
        Console.WriteLine(number % 5 == 0 && number % 7 == 0);
    }
}

