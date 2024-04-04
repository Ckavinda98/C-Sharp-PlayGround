using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oopInheritence.Models
{
    public class Course : Audit
     {
        public int Id {get; set;}

        public string Title {get; set;}
        public string Note {get; set;}
        public decimal Fee {get; set;}
    }
}