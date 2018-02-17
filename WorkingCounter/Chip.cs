using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCounter
{
    class Chip : ICountable
    {
        //implements iCountable as it counts a single object a Chip.
        public int Count => 1;
    }
}
