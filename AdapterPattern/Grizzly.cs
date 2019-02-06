// Author: Nicholas Pica
// Title: Grizzly.cs
// Purpose: To implement code for the funtions.
// Date: 2/6/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Grizzly : IBear
    {
        void IBear.Hibernate()
        {
            Console.WriteLine("The bear hibernates");
        }

        void IBear.Maul()
        {
            Console.WriteLine("The bear completely destroys you....now you're dead");
        }
    }
}
