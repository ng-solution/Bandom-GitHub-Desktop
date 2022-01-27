using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Sarasas = new List<string>();
            foreach (string item in args)
            {
                Sarasas.Add(item);
            }
            Console.WriteLine($"Hello World");
        }
    }
}
