using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingMode.Command
{
    internal abstract class Command : ICommand
    {
        protected bool enabled;
        public bool Enabled { get; set; }

        public virtual void Execute()
        {

        }
    }
}
