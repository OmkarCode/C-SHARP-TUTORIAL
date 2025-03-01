﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int> { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15 };
            var evenNumbers = from num in number where num%2==0 select num;
            foreach(var num in evenNumbers)
            {
                Console.WriteLine(num); 
            }
        }
    }
}
