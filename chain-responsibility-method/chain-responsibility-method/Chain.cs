using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_responsibility_method
{
    public class Chain
    {
        private Processor chain;

        public Chain()
        {
            BuildChain();
        }

        private void BuildChain()
        {
            chain = new NegativeProcessor(new ZeroProcessor(new PositiveProcessor(null)));
        }

        public void Process(Number request)
        {
            chain.Process(request);
        }
    }
}
