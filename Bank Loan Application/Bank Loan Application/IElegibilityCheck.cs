using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Loan_Application
{
    interface IElegibilityCheck
    {
        void CheckAmountRequested(int loanAmount);
        void CheckAge(DateTime DOB);
        void CheckYearlyNetIncome(int incomeAmount, string howOften);
        void CheckCreditScore(int loanAmount, int creditScore);
        bool isQualifiedForLoan(int loanAmount);
        void calculateInterest(int creditScore);
    }
}
