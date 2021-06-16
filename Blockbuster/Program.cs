using System;
using System.Collections.Generic;

namespace Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockBusterVideo bv = new BlockBusterVideo();

            bv.PrintAllMovies();
            bv.Checkout();

            bv.PrintInfo();






        }
    }
}
