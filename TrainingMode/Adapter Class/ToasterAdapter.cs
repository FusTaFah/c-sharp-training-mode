using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingMode
{
    internal class ToasterAdapter : PaniniPress
    {
        Toaster toastrr;

        public ToasterAdapter(Toaster _tostr) : base(1, 5)
        {
            toastrr = _tostr;
        }

        public override string TouchBrown(string bread)
        {
            return "motherfucking " + toastrr.Brown(bread) + " But by a panini press lmfao";
        }
    }
}
