﻿using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust;
            //programm kuvab kasutaja vanust konsoolis;

            Console.WriteLine("Palun, sisesta oma sünniaasta: ");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            //Console.WriteLine("oled" + userAge + "aastat vana");

            //string interpolation

            Console.WriteLine($"Oled {userAge} aastat vana.");


        }
    }
}
