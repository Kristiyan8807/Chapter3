//Напишете израз, който изчислява площта на трапец по дадени
//страни a и b и височина h.
using System;

namespace _05Task
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 7;
            int h = 12;
            int S = (a + b) * h / 2;
            Console.WriteLine(S);

        }
    }
}
