using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oopInheritence.Models
{
    public class Audit
    {
        public int CreatedId {get; set;}

        public DateTime CreatedDate {get; set;}
        public int UpdatedID {get; set;}
        public DateTime UpdatedDate {get; set;}
    }
}