//Напишете програма, която проверява дали дадено число n(1 < n< 100)
//е просто(т.е.се дели без остатък само на себе си и на единица).
using System;

class Program
{
    static void Main()
    {
        int number = 8;
        bool isPrime = true;
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        Console.WriteLine(isPrime);
    }
}

