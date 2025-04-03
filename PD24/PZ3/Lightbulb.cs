using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ3
{
    public class Lightbulb: ISwitcheable
    {
       
        public void Activate()
        {
            Console.WriteLine("Lightbulb Activate");
        }

        public void Deactivate() 
        { 
            Console.WriteLine("Lightbulb Deactivate"); 
        }
    }
}
