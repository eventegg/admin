using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            CoreEventEggDbEntities1 e=new CoreEventEggDbEntities1();

            
            e.PersonDetails.Add(new PersonDetails());

        }
    }
}
