using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oopInheritence
{
    public class Dog : Pet
    {
        public override void Walk()
        {
            Console.WriteLine("Dog is Walking");
        }
    }
}