using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_and_oil_station_task
{
    internal class Check
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Name} {Count} {Price}";
        }
    }
}
