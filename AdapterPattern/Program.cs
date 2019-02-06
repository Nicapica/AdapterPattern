// Author: Nicholas Pica
// Title: Program.cs
// Purpose: To show that the functions worked properly.
// Date: 2/6/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBear bear = new Grizzly();
            bear.Maul();
            bear.Hibernate();
            IToyBear toy1 = new TeddyBear();
            toy1.Hug();
            IToyBear toy2 = new BearAdapter(bear);
            toy2.Hug();
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
