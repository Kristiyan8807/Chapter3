﻿//Напишете програма, която проверява дали дадена точка О(x, y) е
//вътре в окръжността К({ 0,0}, R=5) и едновременно с това извън
//правоъгълника[{-1, 1}, {5, 5}]. Пояснение: правоъгълникът е
//зададен чрез координатите на долния си ляв и горния си десен ъгъл.
using System;

class Program
{
    static void Main()
    {
        int x = 5;
        int y = 6;
        Console.WriteLine(((x * x) + (y * y) <= 5 * 5 && !((-1 < x && x < 5) && (1 < y && y < 5))) ? "In" : "Out"); 
    }
}
