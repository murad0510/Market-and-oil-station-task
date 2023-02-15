using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_and_oil_station_task
{
    internal class Oil
    {
        public string OilName { get; set; }
        public double OilPrice { get; set; }

        public override string ToString()
        {
            return $@"{OilName}";
        }
    }
}
