using System;
using System.Collections.Generic;
using System.Text;

namespace MobileBillCalculator
{
    public class Entity
    {
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }
        private DateTime GetDate { get; set; }
        private DateTime Overlap { get; set; }
        public float Bill { get; set; }
    }
}
