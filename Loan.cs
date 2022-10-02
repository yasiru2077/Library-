using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Loan
	{
        private static int nextId = 1;

        public Member Borrower { get; }
        public Copy Copy { get; }
        public DateTime DueDate { get;  set; }
        public int Id { get; }
        public DateTime LoanDate { get; }
        public int NumberOfRenewals { get;  set; }
        public DateTime ReturnDate { get;  set; }


        public Loan(Member m, Copy c)
        {
            Id = nextId++;
            Borrower = m;
            Copy = c;
            LoanDate = DateTime.Now;
            DueDate = LoanDate.AddDays(14);
            NumberOfRenewals = 0;
            Copy.State = Copy.ON_LOAN_STATE;
        }

        public bool RenewLoan()
        {
            if (NumberOfRenewals < 3)
            {
                NumberOfRenewals++;
                DueDate = DueDate.AddDays(14);
                return true;
            }
            return false;
        }

        public bool ReturnBook()
        {
            if (Copy.State.Equals(Copy.ON_LOAN_STATE))
            {
                ReturnDate = DateTime.Now;
                Copy.State = Copy.AVAILABLE_STATE;
                return true;
            }
            return false;
        }

    }
}
