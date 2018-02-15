using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCounter
{
    public class Apple: iCountable
    {
        string colour = "red";

        int iCountable.Count => 1;
    }
}
