using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingMode.Command
{
    internal class KappaAction : Command
    {
        public KappaAction(bool _enabled)
        {
            enabled = _enabled;
        }

        public override void Execute()
        {
            if (enabled)
            {
                Console.WriteLine("Kappa!");
            }
        }
    }
}
