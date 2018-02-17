using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCounter
{
    public class Box : Counter<ICountable>
    {
        //doesn't need any code as it inherits all methods from the Counter Generic class.

    }
}

