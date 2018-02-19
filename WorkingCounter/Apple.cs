using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCounter
{
    public class Apple: ICountable
    {
        public string ColourRed = "red";
        public string ColourGreen = "green";

        int ICountable.Count => 1;
    }
}
