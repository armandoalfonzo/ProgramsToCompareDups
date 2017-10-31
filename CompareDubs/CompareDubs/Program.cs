using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareDubs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting process DupCleaning..");

            // Start the two near dupe delete process
            new CompareTwoNearDupes().Process();

            Console.WriteLine("..Program ended, shutting down");
            Console.Read();
        }
    }
}
