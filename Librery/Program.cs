using Librery.Generic;
using System;

namespace Librery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            
            list.Add("Груша");
            list.Add("Волос");
            list.Add("Сорочка");
            list.Add("Носок");
            list.Add("Нокіа");
            list.Remove(3);

            Console.WriteLine(list.getItem(2));

            
           
        }
    }
}
