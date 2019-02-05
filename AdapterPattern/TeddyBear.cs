using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class TeddyBear : ToyBear
    {
        void ToyBear.Hug()
        {
            Console.WriteLine("The toy bear hugs you");
        }
    }
}
