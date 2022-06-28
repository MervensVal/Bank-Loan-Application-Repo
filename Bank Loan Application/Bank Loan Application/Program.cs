using System;

namespace Bank_Loan_Application
{
    class Program
    {
        static void Main(string[] args)
        {

            BankLoanEligibilityCheck();
        }

        public static void BankLoanEligibilityCheck()
        {
            bool canContinueLoop = true;
            string continueLoop;

            while (canContinueLoop)
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("Check new applicant eligibility for loan? (Y or N)");
                    continueLoop = (Console.ReadLine()).ToUpper();
                    Console.WriteLine("");

                    if (continueLoop == "N")
                    {
                        canContinueLoop = false;
                        Console.WriteLine("Bank Loan App ended by user");
                        Console.WriteLine("");
                    }
                    else if (continueLoop == "Y")
                    {
                        Menu();
                    }
                    else 
                    {
                        Console.WriteLine("Incorrect Input");
                        Console.WriteLine("");

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Incorrect data entered");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine(e);
                    Console.WriteLine("");

                }
            }
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
            string howOftenPaidU;
            hasExistingLoan = true;

            EligibilityCheck userECheck = new EligibilityCheck();


            Console.WriteLine("");
            Console.WriteLine("Welcome to the Loan App!");
            Console.WriteLine("To determine eligibility please complete the form");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Does Applicant have an open/existing loan with our bank? (Y/N) ");
            hasExistingLoanStr = Console.ReadLine();
            hasExistingLoanStr = hasExistingLoanStr.ToUpper();

            switch (hasExistingLoanStr)
            {
                case "Y":
                    hasExistingLoan = true;
                    break;
                case "N":
                    hasExistingLoan = false;
                    break;
                default:
                    Console.Write("");
                    Console.WriteLine("incorrect user input");
                    break;
            }

            if (hasExistingLoan == true && hasExistingLoanStr == "Y")
            {
                Console.WriteLine("");
                Console.WriteLine("Applicant does not qualify. Only one loan can be open at one time per Applicant ");
            }
            else if (hasExistingLoan == false && hasExistingLoanStr == "N")
            {
                Console.WriteLine("");
                Console.WriteLine("Applicant Date of Birth: ");

                checkAge = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("Loan amount requested (Only $2000 - $30,000): ");
                loanAmount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("How frequently does applicant get paid");
                Console.WriteLine("Type M for Monthly | BW for Bi-Weekly | W for Weekly | Y for Yearly:  ");
                howOftenPaid = Console.ReadLine();
                howOftenPaidU = howOftenPaid.ToUpper();

                Console.WriteLine("");
                Console.WriteLine("Income (based on frequency that was entered above):  ");
                income = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("Credit score:  ");
                creditScore = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");
                userECheck.CheckAge(checkAge);

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");
                userECheck.CheckAmountRequested(loanAmount);

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");
                userECheck.CheckYearlyNetIncome(income, howOftenPaidU);

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");
                userECheck.CheckCreditScore(income, creditScore);

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");
                switch (userECheck.isQualifiedForLoan(loanAmount)) 
                {
                    case true:
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("");
                        userECheck.calculateInterest(creditScore);
                        break;
                    case false:
                        break;
                }

                userECheck.saveToDB();

            }
        }
    }
}
