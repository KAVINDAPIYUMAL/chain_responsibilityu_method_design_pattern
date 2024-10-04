using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_responsibility_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Chain chain = new Chain();

            // Calling chain of responsibility
            chain.Process(new Number(90));
            chain.Process(new Number(-50));
            chain.Process(new Number(0));
            chain.Process(new Number(91));

            Console.ReadLine();
        }
    }
}
