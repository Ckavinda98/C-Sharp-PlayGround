using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oopInheritence
{
    public class Pet
    {
        public string Name {get; set;}
        public int Age {get; set;}

        public virtual void Walk()
        {
            Console.WriteLine("Pet is Walking");
        }

    }
}