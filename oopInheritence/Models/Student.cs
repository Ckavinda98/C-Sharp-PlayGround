using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oopInheritence.Models
{
    public class Student : Audit
    {
        public int id {get; set;}
        public string FirstName {get; set;}
        public string  LastName {get; set;}
        public int DateTIme JoinedDate {get; set;}
        
    }
}