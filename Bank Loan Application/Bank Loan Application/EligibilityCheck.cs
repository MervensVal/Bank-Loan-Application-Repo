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
            currentAge = (currentDate.Year - DOB.Year) - 1;
            if (currentAge >= 18)
            {
                Console.WriteLine("");
                Console.WriteLine("Applicant age: " + currentAge + " years old");
                Console.WriteLine("Applicant is old enough");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Applicant age: " + currentAge + " years old");
                Console.WriteLine("Applicant is NOT old enough");
                userQualifies = false;
            }
        }

        public void CheckCreditScore(int loanAmount, int creditScore)
        {
            if (creditScore < 600)
            {
                userQualifies = false;
                Console.WriteLine("");
                Console.WriteLine("Credit score of " + creditScore + " is too low");
            }
            else if (creditScore < 700 && creditScore >= 600 && loanAmount < 10000)
            {
                Console.WriteLine("");
                Console.WriteLine("Credit score is good");
            }
            else if (creditScore >= 700)
            {
                Console.WriteLine("");
                Console.WriteLine("Credit score is good");
            }
            else
            {
                userQualifies = false;
                Console.WriteLine("");
                Console.WriteLine("Credit score of " + creditScore + " is too low for loan amount");
            }
        }

        public void CheckAmountRequested(int loanAmount)
        {
            if (loanAmount >= 2000 && loanAmount <= 30000)
            {
                Console.WriteLine("");
                Console.WriteLine("Loan amount is good");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Loan amount not approved. Must be $2000 - $30,000");
                userQualifies = false;
            }
        }

        public void CheckYearlyNetIncome(int incomeAmount, string howOftenPaid)
        {
            int yearlyIncome = 0;
            string howOftenPaidU = null;
            howOftenPaidU = howOftenPaid.ToUpper();
            switch (howOftenPaidU)
            {
                case "BW":
                    yearlyIncome = ((52 * incomeAmount) / 2);
                    break;
                case "M":
                    yearlyIncome = (12 * incomeAmount);
                    break;
                case "W":
                    yearlyIncome = (52 * incomeAmount);
                    break;
                case "Y":
                    yearlyIncome = incomeAmount;
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect value entered");
                    break;
            }

            if (yearlyIncome < 45000)
            {
                Console.WriteLine("");
                Console.WriteLine("Yearly income is too low");
                userQualifies = false;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Yearly income is good");
            }
        }

        public bool isQualifiedForLoan(int loanAmount)
        {
            if (userQualifies)
            {
                Console.WriteLine("");
                Console.WriteLine("User qualifies for the loan amount requested");
                Console.WriteLine("Approved loan amount: " + loanAmount);
                return true;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("User does not qualify for the loan amount requested");
                Console.WriteLine("Rejected loan amount: " + loanAmount);
                return false;
            }
        }

        public void calculateInterest(int creditScore)
        {
            int interestRate;

            if (creditScore >= 600 && creditScore < 650)
            {
                interestRate = 20;
                Console.WriteLine("");
                Console.WriteLine("Your interest rate will be " + interestRate + "%");
            }
            else if (creditScore >= 650 && creditScore < 700)
            {
                interestRate = 15;
                Console.WriteLine("");
                Console.WriteLine("Interest rate will be " + interestRate + "%");
            }
            else if (creditScore >= 700 && creditScore < 750)
            {
                interestRate = 10;
                Console.WriteLine("");
                Console.WriteLine("Interest rate will be " + interestRate + "%");
            }
            else if (creditScore >= 700)
            {
                interestRate = 5;
                Console.WriteLine("");
                Console.WriteLine("Interest rate will be " + interestRate + "%");
            }
            else 
            {
                Console.WriteLine("");
                Console.WriteLine("Credit score is too low for loan");
            }
        }
    }
}

