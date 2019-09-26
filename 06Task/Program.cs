//Напишете програма, която за подадени от потребителя дължина и
//височина на правоъгълник пресмята и отпечатва на конзолата него-
//вите периметър и лице.
using System;

namespace _06Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете дължина и височина на правоъгълник: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = a * b;
            int result2 = (a * 2) + (b * 2);
            Console.WriteLine("Лицето на правоъгълника е " + result);
            Console.WriteLine("Периметъра на правоъгълника е  " + result2);

        }
    }
}
