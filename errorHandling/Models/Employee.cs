using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace errorHandling.Models
{
    public class Employee
    {
        public string Name {get; set;}
        public string Email {get; set;}
        public decimal NetSalary {get; set;}
        public decimal LoanAmount {get; set;}

        public decimal GetNetSalary()
        {
            if(this.LoanAmount > this.NetSalary)
            throw new NetSalaryException();
            return this.NetSalary - this.LoanAmount;
        }


    }
}