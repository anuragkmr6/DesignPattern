using System;

namespace Structural
{
    public class PersonalLoanFacade
    {
        Loan loan = new Loan();
        Credit credit = new Credit();

        public bool IsEligible(Customer customer)
        {
            bool eligible = true;
            if(loan.HasBadLoan(customer))
            {
                eligible = false;
            }
            else if(credit.HasBadCreditScore(customer))
            {
                eligible = false;
            }
            return eligible;
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Loan
    {
        internal bool HasBadLoan(Customer customer)
        {
            Console.WriteLine($"{customer.Name} has no bad loan.");
            return false;
        }
    }

    internal class Credit
    {
        internal bool HasBadCreditScore(Customer customer)
        {
            Console.WriteLine($"{customer.Name} has good credit score.");
            return false;
        }
    }
}
