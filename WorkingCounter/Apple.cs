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
        private int v;


        public Apple(int v)
        {
            this.v = v;
        }

        int ICountable.Count => 1;
    }
}
