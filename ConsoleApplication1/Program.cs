using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var testlist = new List<int> { 1, 2, 3 };
            var testlist2 = new List<int> { 1, 2, 3, 4, 5 };

            foreach (int nValue in testlist)
            {
                var result = testlist2.Where(x => x == nValue).Any();
            }

        }
    }
}
