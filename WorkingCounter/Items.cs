﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCounter
{
    public class Items
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public Items(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

    }
}
