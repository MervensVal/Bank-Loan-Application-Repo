using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Loan_Application
{
    class EligibilityCheck : IElegibilityCheck
    {
        public EligibilityCheck()
        {

        }
        public bool CheckAge(DateTime DOB)
        {
            throw new NotImplementedException();
        }

        public bool CheckCreditScore(int loanAmount, int creditScore)
        {
            throw new NotImplementedException();
        }

        public bool CheckAmountRequested(int loanAmount)
        {

            throw new NotImplementedException();

        }

        public bool CheckYearlyNetIncome(int incomeAmount, string howOftenPaid)
        {
            throw new NotImplementedException();
        }
    }
}
