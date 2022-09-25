using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingMode.Command
{
    internal class BatchestAction : Command
    {
        public BatchestAction(bool _enabled)
        {
            enabled = _enabled;
        }

        public override void Execute()
        {
            if (enabled)
            {
                Console.WriteLine("Batchest");
            }
        }
    }
}
