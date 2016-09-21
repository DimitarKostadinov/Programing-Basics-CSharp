﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point2
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());

            var left = Math.Min(first, second);
            var right = Math.Max(first, second);
            var leftDistance = Math.Abs(point - left);
            var rightDistance = Math.Abs(point - right);
            var distance = Math.Min(leftDistance, rightDistance);

            if (point>=left && point<=right)
            {
                Console.WriteLine("In\n {0}", distance);
            }
            else
	        {
                Console.WriteLine("Out\n {0}", distance);
	        }
        }
    }
}
