using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;



namespace oopConcept
{
    public class BankAccount
    {
        private static int accountSeedNumber = 1234567890;
        private List<Transaction> alltrancsactions = new List<Transaction>();
        public string Number {get;}
        public string Owner {get; set; }
        public decimal Balance 
        {
            get 
            {
                decimal balance = 0;

                foreach(var item in alltrancsactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        public BankAccount(string name, decimal intialamount)
        {
            this.Owner = name;
            this.Number = accountSeedNumber.ToString();
            accountSeedNumber++;


            MakeDeposit(intialamount, DateTime.Now, "Initial Ammount");        
        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),
                "Amount of Deposit must be Positive");
            }
            var deposit = new Transaction(amount, date, note);
            alltrancsactions.Add(deposit);
        }

        public void MakeWithdraw(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),
                "Amount of Withdrawl must be Positive");
            }

            if(this.Balance - amount <= 0)
            {
                throw new InvalidOperationException("Amount of Your Account is Not Sufficent");
            }
            var withdrawl = new Transaction(-amount, date, note);
            alltrancsactions.Add(withdrawl);
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            decimal balance  = 0;

            report.AppendLine("Date\tAmount\tNote");
            foreach(var item in  alltrancsactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t" +
                $"{item.Amount}\t" +
                $"{item.Notes}");
            }
            return report.ToString();
        }
    }   
}