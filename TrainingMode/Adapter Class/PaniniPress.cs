using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingMode
{
    internal class PaniniPress
    {
        private int slots;
        private int timeToToast;

        public PaniniPress(int _slots, int _timeToToast)
        {
            slots = _slots;
            timeToToast = _timeToToast;
        }

        public virtual string TouchBrown(string sandwich)
        {
            return sandwich + " is cooked";
        }
    }
}
