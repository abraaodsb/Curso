using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Entities
{
    class Reservation
    {
        public int RoonNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roonNumber, DateTime checkin, DateTime checkOut)
        {
            RoonNumber = roonNumber;
            CheckIn = checkin;
            CheckOut = checkOut;
        }
         public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void updateDates(DateTime checkIn, DateTime  checkOut)
        {
            CheckIn = CheckIn;
            CheckOut = CheckOut;
        }
        public override string ToString()
        {
            return "Room"
                + RoonNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + "nights";
        }
    }
}
