//Силата на гравитационното поле на Луната е приблизително 17% от
//това на Земята.Напишете програма, която да изчислява тежестта на
//човек на Луната по дадената тежест на Земята.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(0.17 * number);
    }
}

