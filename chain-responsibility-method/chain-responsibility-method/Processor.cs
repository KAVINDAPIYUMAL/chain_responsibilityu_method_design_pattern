using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_responsibility_method
{
    public abstract class Processor
    {
        private readonly Processor nextProcessor;

        public Processor(Processor nextProcessor)
        {
            this.nextProcessor = nextProcessor;
        }

        public virtual void Process(Number request)
        {
            if (nextProcessor != null)
                nextProcessor.Process(request);
        }
    }

}
