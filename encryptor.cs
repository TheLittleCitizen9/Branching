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
            string result = "";
            foreach (var arg in args)
            {
                string resultInInt = _secret(arg);
                resultInInt += 1;
                result += (char)resultInInt;
            }

            Console.WriteLine(result);
        }
    }
}
