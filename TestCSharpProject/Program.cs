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
            Console.WriteLine(x);

            CallNewFeature(x);
        }

        private static void CallNewFeature(string s)
        {
            throw new NotImplementedException();
        }
    }
}
