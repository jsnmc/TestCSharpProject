using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpProject
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Some changes here
            string x = "my new change";

            CallNewFeature(x);
        }

        private static void CallNewFeature(string s)
        {
            Console.WriteLine(s);
        }
    }
}
