using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace harmonictrader.ViewModel
{
    public class Pattern
    {
        public string Name { get; set; }
        public double XD { get; set; }
        public bool IsClosestRatio { get; set; } = false;
        public ICollection<double> XA { get; set; }
        public ICollection<double> AB { get; set; }
        public ICollection<double> BC { get; set; }
    }
}
