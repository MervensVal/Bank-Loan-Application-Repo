using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Loan_Application
{
    class EligibilityCheck : IElegibilityCheck
    {
        private bool userQualifies = true;
        public EligibilityCheck()
        {

        }
        public void CheckAge(DateTime DOB)
        {
            int currentAge;
            DateTime currentDate = DateTime.Today;
            currentAge = (currentDate.Year - DOB.Year)-1;
            if (currentAge >= 18)
            {
                Console.WriteLine("Applicant age: " + currentAge + "years old");
                Console.WriteLine("Applicant is old enough");
            }
            else 
            {
                Console.WriteLine("Applicant age: " + currentAge + "years old");
                Console.WriteLine("Applicant is NOT old enough");
                userQualifies = false;
            }
        }

        public void CheckCreditScore(int loanAmount, int creditScore)
        {
            throw new NotImplementedException();
        }

        public void CheckAmountRequested(int loanAmount)
        {
            throw new NotImplementedException();
        }

        public void CheckYearlyNetIncome(int incomeAmount, string howOftenPaid)
        {
            throw new NotImplementedException();
        }

        public bool isQualifiedForLoan()
        {
            throw new NotImplementedException();
        }
    }
}
