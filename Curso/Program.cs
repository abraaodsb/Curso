﻿using System;
using System.Globalization;
using System.Collections.Generic;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string day;

           switch (x)
            {
                case 1:
                    day = "sunday";
                    break;
                case 2:
                    day = "monday";
                    break;
                case 3:
                    day = "tuesday";
                    break;
                case 4:
                    day = "wednesday";
                    break;
                case 5:
                    day = "thursday";
                    break;
                case 6:
                    day = "friday";
                    break;
                case 7:
                    day = "saturday";
                    break;
                default:
                    day = "invalid value";
                    break;
            }

            Console.WriteLine("day:" + day);
        }
    }
}

