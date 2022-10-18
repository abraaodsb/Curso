using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Entities
{
    class BusinessAccount : Account 
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount (int number, string holder, double balance, double loanLimit)  
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
