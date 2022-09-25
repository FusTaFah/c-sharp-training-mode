using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingMode.Iterator
{
    internal class ArrayIterator
    {
        int[] array;
        uint currentElement;

        public ArrayIterator(int[] _array)
        {
            this.array = _array;
        }

        public int Next()
        {
            return array[++currentElement];
        }

        public bool HasNext()
        {
            if(currentElement < array.Length)
            {
                return true;
            }
            return false;
        }
    }
}
