﻿using System;

class MainClass
{
    public static void Main(string[] args)
    {
        DaysOfWeek MyFavoriteDay;

        MyFavoriteDay = DaysOfWeek.Friday;

        Console.WriteLine(MyFavoriteDay);
    }
}

enum DaysOfWeek : byte
{
    Monday = 1,
    Thuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
