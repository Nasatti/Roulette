using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette_server
{
    public class Number
    {
        public int n { get; set; }
        public string color { get; set; }
        public Number(int n, string color)
        {
            this.n = n;
            this.color = color;
        }
    }
}
