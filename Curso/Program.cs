using Curso.Enums;
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
        static void Main(string[] args, object fileInfo)
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
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                FileInfo fileI = new FileInfo(sourcePath);
                //fileInfo,CopyTo(targetPath);//
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            #endregion          
        }
    }
}


