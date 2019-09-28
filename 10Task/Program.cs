//Напишете програма, която приема за вход четирицифрено число във
//формат abcd(например числото 2011) и след това извършва следните
//действия върху него:
//- Пресмята сбора от цифрите на числото(за нашия пример 2+0+1+1
//= 4).
//- Разпечатва на конзолата цифрите в обратен ред: dcba(за нашия
//пример резултатът е 1102).
//- Поставя последната цифра на първо място: dabc(за нашия пример
//резултатът е 1201).
//- Разменя мястото на втората и третата цифра: acbd(за нашия
//пример резултатът е 2101).
using System;

namespace _10Task
{
class Program
{
    static void Main(string[] args)
    {
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int d = int.Parse(Console.ReadLine());
            //Console.WriteLine(a + b + c + d);
            //Console.WriteLine("" + d + c + b + a);
            //Console.WriteLine("" + d + a + b + c);
            //Console.WriteLine("" + a + c + b + d);

            int num = int.Parse(Console.ReadLine());
            int d = num % 10;
            int c = (num / 10) % 10;
            int b = (num / 100) % 10;
            int a = (num / 1000) % 10;
            Console.WriteLine(a + b + c + d);
            Console.WriteLine("" + d + c + b + a);
            Console.WriteLine("" + d + a + b + c);
            Console.WriteLine("" + a + c + b + d);

        }
    }
}
