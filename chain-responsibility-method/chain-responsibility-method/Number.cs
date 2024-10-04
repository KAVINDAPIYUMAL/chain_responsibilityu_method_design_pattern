using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_responsibility_method
{
    public class Number
    {
        private readonly int number;

        public Number(int number)
        {
            this.number = number;
        }

        public int GetNumber()
        {
            return number;
        }
    }
}
