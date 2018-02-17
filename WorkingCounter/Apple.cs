using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCounter
{
    public class Apple: ICountable
    {
        string colour = "red";

        int ICountable.Count => 1;
    }
}
