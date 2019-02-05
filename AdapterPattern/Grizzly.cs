using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Grizzly : Bear
    {
        void Bear.Hibernate()
        {
            Console.WriteLine("The Bear Hibernates");
        }

        void Bear.Maul()
        {
            Console.WriteLine("The Bear Completely destroys you....you're dead");
        }
    }
}
