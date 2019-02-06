// Author: Nicholas Pica
// Title: TeddyBear.cs
// Purpose: To implement code for the funtion.
// Date: 2/6/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class TeddyBear : IToyBear
    {
        void IToyBear.Hug()
        {
            Console.WriteLine("The toy bear hugs you");
        }
    }
}
