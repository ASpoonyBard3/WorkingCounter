using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCounter
{
    class Chip : iCountable
    {
        //implements iCountable as it counts an object
        public int Count => 1;
    }
}
