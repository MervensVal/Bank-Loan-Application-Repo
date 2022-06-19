using System;

namespace Bank_Loan_Application
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();
        }

        public static void Menu() 
        {
            bool hasExistingLoan;
            string hasExistingLoanStr;
            DateTime checkAge;
            int loanAmount;
            string howOftenPaid;
            int income;
            int creditScore;

            hasExistingLoan = true;

            EligibilityCheck userECheck = new EligibilityCheck();

            Console.WriteLine("Welcome to the Loan App!");
            Console.WriteLine("To determine eligibility please complete the form");
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Does Applicant have an open/existing loan with our bank? (Y/N) ");
            hasExistingLoanStr = Console.ReadLine();
            hasExistingLoanStr = hasExistingLoanStr.ToUpper();

            switch (hasExistingLoanStr) 
            {
                case "Y":
                    hasExistingLoan = true;
                    break;
                case "y":
                    hasExistingLoan = true;
                    break;
                case "N":
                    hasExistingLoan = false;
                    break;
                case "n":
                    hasExistingLoan = false;
                    break;
            }


            if (hasExistingLoan)
            {
                Console.WriteLine("Applicant does not qualify. Only one loan can be open at one time per Applicant ");
                //break;
            }
            else
            {
                Console.WriteLine("Applicant Date of Birth: ");
                checkAge = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Loan amount requested (Only $2000 - $30,000): ");
                loanAmount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How frequently does applicant get paid");
                Console.WriteLine("Type M for Monthly | BW for Bi-Weekly | W for Weekly :  ");
                howOftenPaid = Console.ReadLine();

                Console.WriteLine("Income (based on frequency that was entered above):  ");
                income = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Credit score:  ");
                creditScore = Convert.ToInt32(Console.ReadLine());

                userECheck.CheckAge(checkAge);
                userECheck.CheckAmountRequested(loanAmount);
                userECheck.CheckYearlyNetIncome(income, howOftenPaid);
                userECheck.CheckCreditScore(income, creditScore);
            }   
        }
    }
}
