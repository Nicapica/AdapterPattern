// Author: Nicholas Pica
// Title: BearAdapter.cs
// Purpose: To create an adapter between Toybear and Bear.
// Date: 2/6/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class BearAdapter : IToyBear
    {
        IBear bear;

        public BearAdapter (IBear b)
        {
            this.bear = b;
        }
        void IToyBear.Hug()
        {
            this.bear.Maul();
        }
    }
}
