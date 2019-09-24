//Напишете израз, който да проверява дали третата цифра(от дясно
//наляво) на дадено цяло число е 7.
using System;

class Program
{
    static void Main()
    {
        int number = 78960;
        Console.WriteLine(number / 100);
        int number2 = number / 100;
        int number3 = number2 % 10; // винаги когато делим по модул на десет остатъка винаги е последната цифра
        Console.WriteLine(number3 == 7);

    }
}

