//Напишете израз, който да проверява дали третият бит на дадено
//число е 1 или 0.
using System;

class Program
{
    static void Main()
    {
        int num = 27;
        bool bit3 = (num & 8) != 0;
        Console.WriteLine(bit3);
    }
}

