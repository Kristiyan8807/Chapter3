﻿//Напишете програма, която проверява дали дадена точка О {x, y} е
//вътре в окръжността К({ 0,0}, R=5). Пояснение: точката {0,0} е
//център на окръжността, а радиусът ѝ е 5.
using System;

class Program
{
    static void Main()
    {
        int x = 3;
        int y = 4;
        Console.WriteLine(((x * x) + (y * y) <= 25)? "In" : "Out");
    }
}