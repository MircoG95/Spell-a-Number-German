﻿using System;

namespace Spell
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Please enter number: ");
                string eingabe = Console.ReadLine();
                Zahl z = new Zahl(Convert.ToInt32(eingabe));
                Console.WriteLine(z.Spell());
            } while (true);
        }
    }
}
