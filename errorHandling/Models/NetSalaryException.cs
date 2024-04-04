using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace errorHandling.Models
{
    public class NetSalaryException : Exception 
    {
        public NetSalaryException()
        : base("Your Loan Shoudnt be Larger than Your Net Salary")
        {}
    }
}