﻿using Curso.Enums;
using System;
using Curso.Entities;
using System.Globalization;
using System.Collections.Generic;
using Curso.Entities.Enums;
using Curso.Entities.Exceptions;
using System.IO;


namespace Curso
{
    class Program
    {
         static void Main(string[] args)
        {
            #region Program antigo
            //try
            //{
            //    Console.Write("Room number: ");
            //    int number = int.Parse(Console.ReadLine());
            //    Console.Write("Check-in date (dd/MM/yyyy):");
            //    DateTime checkIn = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Check-Out date (dd/MM/yyyy):");
            //    DateTime checkOut = DateTime.Parse(Console.ReadLine());



            //    Reservation reservation = new Reservation(number, checkIn, checkOut);
            //    Console.WriteLine("Reservation: " + reservation);

            //    Console.WriteLine();
            //    Console.WriteLine("Enter data to update the reservation:");
            //    Console.Write("Check-in date (dd/MM/yyyy):");
            //    checkIn = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Check-Out date (dd/MM/yyyy):");
            //    checkOut = DateTime.Parse(Console.ReadLine());

            //    reservation.updateDates(checkIn, checkOut);
            //    Console.WriteLine("Reservatiom: " + reservation);

            //}
            //catch (CannotUnloadAppDomainException e)
            //{
            //    Console.WriteLine("Error in reservation: " + e.Message);
            //}

            #endregion


            #region File/FileInfo/Exception
            string path = @"c:\temp\file1.txt";
            try {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            #endregion
            
        }
    }
}


