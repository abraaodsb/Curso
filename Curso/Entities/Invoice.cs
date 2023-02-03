using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Curso.Entities
{
    class Invoice
    {
        public double basicPayment { get; set; }
        public double tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            this.basicPayment = basicPayment;
            this.tax = tax;
        }

        public double TotalPayment {
            get { return basicPayment + tax; }
        }

        public override string ToString()
        {
            return "Basic payment: " 
                +  basicPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
