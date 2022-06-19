using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Loan_Application
{
    interface IElegibilityCheck
    {
        bool CheckAmountRequested(int loanAmount);
        bool CheckAge(DateTime DOB);
        bool CheckYearlyNetIncome(int incomeAmount, string howOften);
        bool CheckCreditScore(int loanAmount, int creditScore);



    }
}
