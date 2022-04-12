using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp2
{
    class Product
    {
        public string Name { get; set; }
        public int Energy { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Energy})";
        }
    }
}
