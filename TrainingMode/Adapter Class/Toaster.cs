using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingMode
{
    internal class Toaster
    {
        private int slots;
        private int timeToToast;

        public Toaster(int _slots, int _timeToToast)
        {
            slots = _slots;
            timeToToast = _timeToToast;
        }

        public string Brown(string bread)
        {
            return bread + " is toasted!";
        }
    }
}
