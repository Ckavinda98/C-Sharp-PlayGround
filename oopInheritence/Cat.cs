using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oopInheritence
{
    public class Cat : Pet
    {
        public override void Walk()
        {
            Console.WriteLine("Cat is Walking");
        }
    }
}